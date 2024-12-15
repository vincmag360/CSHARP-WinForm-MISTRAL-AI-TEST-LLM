using Mistral.SDK;
using Mistral.SDK.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;
using System.Collections;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Eventing.Reader;


namespace vinc_app_1
{
    public partial class Form_vinc_1 : Form
    { 
        private MistralClient client;
        private string keyValueCCS;
        private string keyValueBACK;
        private string KeyModelDefault;
        private string keyValue;
        private string pathPrompts = "Prompts.xml";
        private string pathHistoChat = "Chats.xml";
        private Dictionary<string, string> dictionary;
        private Dictionary<string, string> dictionaryChats;
        private uint iChats = 1;
        private string SoutHtml;
        String myFilterSystem;
        String myFilterSystemNoHtml;


        public Form_vinc_1()
        {
           InitializeComponent();

            splitContainer4.IsSplitterFixed = true;
            splitContainer4.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.FixedPanel = FixedPanel.Panel1;

            webBrowser1.NewWindow += new CancelEventHandler(NewWindowEventHandler);
            dictionary = new Dictionary<string, string>();
            dictionaryChats = new Dictionary<string, string>();

            this.Text = "Welcome to Vincent's LLM Chat powered by Mistral AI  - version 1.3 (Html - models)";
            
            LoadHTMLFile(); 
            GetNode();
            LoadXMLChats();
            LoadXMLPrompts();
            FillListBox();
            LoadSystem();

        }

        private void FillListBox()
        {
            listBoxPrompt.Items.Clear();
            foreach (var key in dictionary.Keys)
            {
                listBoxPrompt.Items.Add(key);
            }
        }

        private void InitChats()
        {

            iChats = 1;
            String sIA = "Vous êtes un chatbot IA. Votre tâche est de répondre aux questions de l'utilisateur de manière précise et utile. Merci de détecter la langue utilisé par l'Humain (apres HUMAIN :)";
            dictionaryChats.Clear();
            dictionaryChats[iChats.ToString()+" :"] = sIA;

          
        }



            private void LoadXMLChats()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathHistoChat);

                foreach (XmlNode node in xmlDoc.SelectNodes("//item"))
                {
                    string key = node.SelectSingleNode("key")?.InnerText;
                    string value = node.SelectSingleNode("value")?.InnerText;
                    if (key != null && value != null)
                    {
                        dictionaryChats[key] = value;
                    }

                    string result = key.Split(':')[0];
                    uint.TryParse(result, out iChats);





                }
            }
            catch (Exception ex)
            {

                textBox1.Text = "Error load Chats file :" + pathHistoChat + " " + ex.Message + "\n";
                InitChats();
            }

        }

        private string LoadStringChats()
        {

            string schats = "";

            foreach (var kvp in dictionaryChats)
            {
               schats = schats + "\r\n"+ kvp.Key + kvp.Value+ "\r\n";             
            }

            return schats;

        }

        private string LoadStringChatsHtml()
        {

            string schats = "";

            foreach (var kvp in dictionaryChats)
            {
                schats = schats + "<br>" + kvp.Key + kvp.Value + "<br>";
            }

            return schats;

        }


        private void LoadXMLPrompts()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathPrompts);

                foreach (XmlNode node in xmlDoc.SelectNodes("//item"))
                {
                    string key = node.SelectSingleNode("key")?.InnerText;
                    string value = node.SelectSingleNode("value")?.InnerText;
                    if (key != null && value != null)
                    {
                        dictionary[key] = value;
                    }
                }
            }
            catch (Exception ex)
            {

                textBox1.Text = "Error load prompt file :"+ pathPrompts +" "+ ex.Message + "\n";
            }
           
        }


       


            private void LoadHTMLFile()
        {
            string filePath = "hello.html";
            if (File.Exists(filePath))
            {
                string htmlContent = File.ReadAllText(filePath);
                webBrowser1.DocumentText = htmlContent;
            }
            else
            {
                textBox1.Text = "The file hello.html does not exist.";
            }
        }

        private void NewWindowEventHandler(object sender, CancelEventArgs e)
        {
         e.Cancel = true;
        }



       

        private async Task Button1_ClickAsync(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = "";
            webBrowser1.ScriptErrorsSuppressed = true;
            try
            {            
               await GenerateSonnetAsync(); 
            }
            catch (Exception ex)
            {      
                textBox1.Text = "An error occurred:" + ex.Message + "\n";
            }
        }

        private void GetNode()
        {

            string filePath = "fichier.xml";
           
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(filePath);
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error while loading the XML file:" + ex.Message;
                return;
            }

            XmlNode keyNode = xmlDoc.SelectSingleNode("/configuration/settings/Key");
            XmlNode keyNodeCCS = xmlDoc.SelectSingleNode("/configuration/settings/KeyCCS");
            XmlNode keyNodeBack = xmlDoc.SelectSingleNode("/configuration/settings/KeyBACK");
            XmlNode keyNodeModelsDefault = xmlDoc.SelectSingleNode("/configuration/settings/KeyModelDefault");

            KeyModelDefault = keyNodeModelsDefault.InnerText;
            keyValueCCS = keyNodeCCS.InnerText;
            keyValueBACK = keyNodeBack.InnerText;

            if (keyNode != null)
            {
                keyValue = keyNode.InnerText;
                client = new MistralClient(keyValue);

                textBox1.AppendText("WELCOME");
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText("Key API OK: **********" + GetLastFiveCharacters(keyValue));
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText("Enjoy !");

                _ = GetModels();

            }
            else
            {
                textBox1.Text = "Key API : The 'Key' node was not found in the XML file";
            }
        }



private async Task GetModels()
{
    try
    {
        var client2 = new MistralClient(keyValue);
        var response2 = await client2.Models.GetModelsAsync();
        foreach (var model in response2.Data)
        {
            listBox1.Items.Add(model.Id);
        }

        int index = listBox1.FindStringExact(KeyModelDefault);
        if (index != ListBox.NoMatches)
        {
            listBox1.SetSelected(index, true);
        }
        else
        {
            textBox1.Text = "No default Model - not found in the XML file";
        }
    }
    catch (Exception ex)
    {
        // Log or handle the exception
        textBox1.Text = $"An error occurred: {ex.Message}";
    }
}
       private async Task GenerateSonnetAsync()
        {           
            String myModel = "";        
            myModel = listBox1.Text;

            
            String myFiltFinal = "";            

            if (chkBoxAuto.Checked)
            {
                myFiltFinal = myFilterSystem;
            }
            else
            {
                myFiltFinal= myFilterSystemNoHtml;
            }

            if (txtboxInput.Text != "")
            {

                string sprompt = "";
                if (!checkBoxChat.Checked)
                {
                    sprompt = txtboxInput.Text;
                }
                else
                {
                    iChats = iChats+1;
                    sprompt = LoadStringChats();
                    sprompt = sprompt + "\n"+ "HUMAIN : " + txtboxInput.Text+ "\n";
                    dictionaryChats[iChats.ToString()+ " : HUMAIN : "] = txtboxInput.Text;
                }

                var request = new ChatCompletionRequest(
                    myModel,
                    new List<ChatMessage>()
                    {
                        new ChatMessage(ChatMessage.RoleEnum.System,myFiltFinal),                  
                        new ChatMessage(ChatMessage.RoleEnum.User, sprompt)                      
                    });

                int Cint = 0;
                var sresult = new StringBuilder();
                var results = new List<ChatCompletionResponse>();
                try
                {
                    webBrowser1.DocumentText = "WAIT.......";
                    
                    await foreach (var res in client.Completions.StreamCompletionAsync(request))
                    {
                        results.Add(res);
                        sresult.Append(res.Choices.First().Delta.Content);
                        if (sresult.ToString().StartsWith("```html"))
                        {
                            sresult.Clear();
                        }
                        Cint++;
                        if (Cint > 150)
                        {
                            webBrowser1.DocumentText = sresult.ToString();
                            textBox1.Text = "RETURN TOKENS : " + Cint;
                        }
                        else
                        {                            
                            textBox1.Text = "COMPUTE.......";
                        }
                    }
                }
                catch (Exception ex)
                {
                    textBox1.Text = "An error occurred: " + ex.Message + "\n";
                }
                webBrowser1.DocumentText = sresult.ToString();
                textBox1.Text = "FINISH.......!!!!";

                if (checkBoxChat.Checked)
                {
                    iChats = iChats + 1;
                    dictionaryChats[iChats.ToString() + " : IA : "] = sresult.ToString();
                    SaveChatsToXml();
                }

            }
            else
            {
                textBox1.Text = "NO QUESTION ?";
            }

        }

            private void button2_Click(object sender, EventArgs e)
        {
            txtboxInput.Clear();
            webBrowser1.DocumentText = "";          
        }

        static string GetLastFiveCharacters(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (input.Length < 5)
            {
                return input; 
            }
            return input.Substring(input.Length - 5);
        }

        private void SaveChatsToXml()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode rootNode = xmlDoc.CreateElement("items");
                xmlDoc.AppendChild(rootNode);

                foreach (var kvp in dictionaryChats)
                {
                    XmlNode itemNode = xmlDoc.CreateElement("item");

                    XmlNode keyNode = xmlDoc.CreateElement("key");
                    keyNode.InnerText = kvp.Key;
                    itemNode.AppendChild(keyNode);

                    XmlNode valueNode = xmlDoc.CreateElement("value");
                    valueNode.InnerText = kvp.Value;
                    itemNode.AppendChild(valueNode);

                    rootNode.AppendChild(itemNode);
                }

                xmlDoc.Save(pathHistoChat);
            }
            catch (Exception ex)
            {
                textBox1.Text = "An error occurred:" + ex.Message + "\n";
            }

        }

        private void SaveListBoxToXml()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode rootNode = xmlDoc.CreateElement("items");
                xmlDoc.AppendChild(rootNode);

                foreach (var kvp in dictionary)
                {
                    XmlNode itemNode = xmlDoc.CreateElement("item");

                    XmlNode keyNode = xmlDoc.CreateElement("key");
                    keyNode.InnerText = kvp.Key;
                    itemNode.AppendChild(keyNode);

                    XmlNode valueNode = xmlDoc.CreateElement("value");
                    valueNode.InnerText = kvp.Value;
                    itemNode.AppendChild(valueNode);

                    rootNode.AppendChild(itemNode);
                }

                xmlDoc.Save(pathPrompts);
            }
            catch (Exception ex)
            {
                textBox1.Text = "An error occurred:" + ex.Message + "\n";
            }

        }

        

    

        

        private void LoadSystem()
        {
            myFilterSystem =

               "La réponse doit génèrer une page au format HTML. \n " +
               "La réponse doit génèrer uniquement des balises HTML. \n " +
               "La réponse doit toujours être sous cette forme : <html>  <head><style>" + keyValueCCS + "body {background-color:" + keyValueBACK + "}</style></head></head><body><header></header><footer></footer> </body></html>\n " +
               "Ne pas générer le text qui est avant la balise <html> ou la page HTML. \n " +
               "Si la réponse affiche du code informatique, entre des markdown ``` et ``` ,alors le code doit être dans un cadre avec une bordure de couleur bleu.\n" +
               "Si la langue de la réponse est pas spécifié utiliser la langue utilisé dans la demande.\n";



            myFilterSystemNoHtml = "Chaque ligne de la réponse doit être entre deux balises HTML <h4> et </h4> \n";

        }

   
     
        private void btNewPrompts_Click(object sender, EventArgs e)
        {
            if (txtboxInput.Text != "" & txtBoxPrompts.Text != "")
            {
                dictionary[txtBoxPrompts.Text] = txtboxInput.Text;

            }
            FillListBox();
            SaveListBoxToXml();
        }

        private void bdDeletePrompt_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (listBoxPrompt.SelectedItem != null)
                {
                    dictionary.Remove(listBoxPrompt.SelectedItem.ToString());
                    FillListBox();
                    SaveListBoxToXml();

                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "An error occurred:" + ex.Message + "\n";
            }
        }

        private void listBoxPrompt_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxPrompt.SelectedItem != null)
            {
                string selectedItem = listBoxPrompt.SelectedItem.ToString();


                foreach (var kvp in dictionary)
                {
                    string skey = kvp.Key;
                    if (kvp.Key == selectedItem)
                    {
                        txtboxInput.Text = kvp.Value;
                        txtBoxPrompts.Text = skey;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button1_ClickAsync(sender, e).ConfigureAwait(false);
        }

    
       

        private void webBrowser1_Navigating_1(object sender, WebBrowserNavigatingEventArgs e)
        {
            string searchTerm = e.Url.ToString().ToLower();
            bool contains = searchTerm.Contains("about");
            bool containsblank = searchTerm.Contains("about:blank");

            if (!contains)
            {
                System.Diagnostics.Process.Start(e.Url.ToString());
                e.Cancel = true;
            }
            else if (!containsblank) e.Cancel = true;
        }

        private void checkBoxChatbotView_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxChatbotView.Checked)
            {
                checkBoxChat.Enabled = true;
                button1.Enabled = true;
                bdDeletePrompt.Enabled = true;
                btNewPrompts.Enabled = true;
                listBoxPrompt.Enabled = true;
                txtBoxPrompts.Enabled = true;

            }

            if (checkBoxChatbotView.Checked)
            {
                checkBoxChat.Enabled = false;
                button1.Enabled = false;
                bdDeletePrompt.Enabled = false;
                btNewPrompts.Enabled = false;
                listBoxPrompt.Enabled = false;
                txtBoxPrompts.Enabled = false;


                webBrowser1.DocumentText = LoadStringChatsHtml();

            }



        }

        private void checkBoxChat_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxChat.Checked)
            {
                checkBoxChatbotView.Enabled = false;
                checkBoxChatbotView.Checked = false;
            }

            if (checkBoxChat.Checked )
            {
                checkBoxChatbotView.Enabled = true;
             
            }
        }

        private void btDeleteChat_Click(object sender, EventArgs e)
        {

            // Créer une instance de la classe MessageBox
            DialogResult result = MessageBox.Show("Delete historical Chat ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier le résultat de la boîte de dialogue
            if (result == DialogResult.Yes)
            {

                InitChats();
                SaveChatsToXml();
            }
            else if (result == DialogResult.No)
            {
                
            }

            if (checkBoxChatbotView.Checked)
            {
                webBrowser1.DocumentText = LoadStringChatsHtml();

            }



        }
    }


}
