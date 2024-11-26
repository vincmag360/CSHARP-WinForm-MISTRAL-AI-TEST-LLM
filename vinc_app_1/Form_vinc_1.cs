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
        private Dictionary<string, string> dictionary;
        private string SoutHtml;


        public Form_vinc_1()
        {
           InitializeComponent();

            webBrowser1.NewWindow += new CancelEventHandler(NewWindowEventHandler);
            dictionary = new Dictionary<string, string>();

            this.Text = "Welcome to Vincent's LLM Chat powered by Mistral AI  - version 1.3 (Html - models)";

            LoadHTMLFile(); 
            GetNode();
            LoadPrompts();
            FillListBox();

        }

        private void FillListBox()
        {
            listBoxPrompt.Items.Clear();
            foreach (var key in dictionary.Keys)
            {
                listBoxPrompt.Items.Add(key);
            }
        }


        private void LoadPrompts()
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



        private void button1_Click(object sender, EventArgs e)
        {
            Button1_ClickAsync(sender, e).ConfigureAwait(false);
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

             String myFilter =
                "Les 8 points suivants définissent comment doit être formaté la réponse :\n " +
                "point 1 : La réponse doit génèrer une page au format HTML. \n " +
                "point 2 : La réponse doit génèrer uniquement des balises HTML \n " +
                "point 3 : La réponse doit toujours être sous cette forme : <html>  <head>  </head>   <body>background-color: " + keyValueBACK + "; <header></header><footer></footer> </body></html>\n " +
                "Point 4 : Pour la page html générée, utiliser le CCS suivant :\n " + keyValueCCS + "\n " +
                "Point 5 : Ne pas afficher les lignes qui sont avant le mot DOCTYPE et ne doit pas afficher les lignes avant le mot ```html\n " +
                "Point 6 : Ne pas générer le text qui est avant la page HTML. \n " +
                "Point 7 : Si la langue de la réponse est pas spécifié utiliser la langue utilisé dans la demande.\n" +
                "Point 8 : Ne pas utiliser les 5 étapes suivantes si la question ou la demande ne parle pas de code informatique :\n " +
                "Etape 1 : Vous êtes un expert en code informatique.\n " +
                "Etape 2 : L'affichage du code doit utiliser la coloration syntaxique afin d'améliorer la lisibilité et la compréhension.\n " +
                "Etape 3 : Les exemples du code doivent etre dans une bordure de couleur bleue avec un fond de couleur gris clair et doit utiliser une scrollbar verticale ou horizontal.\n"+
                "Etape 4 : Bien séparer les cadres si il y a plusieurs explications ou exemple de code.\n"+
                "Point 5 : Si la langue de la réponse est pas spécifié utiliser la langue utilisé dans la demande.\n";

            String myFilterNoHtml = "Chaque ligne de la réponse doit être entre deux balises <h4> et </h4> \n";
            String myFiltFinal= "";

            

            if (chkBoxAuto.Checked)
            {
                myFiltFinal = myFilter + "\n voici ma demande :\n " + txtboxInput.Text;
            }
            else
            {
                myFiltFinal= myFilterNoHtml+ "\n voici ma demande :\n " + txtboxInput.Text;
            }

            if (txtboxInput.Text != "")
            {
                var request = new ChatCompletionRequest(
                    myModel,
                    new List<ChatMessage>
                    {

                        new ChatMessage(ChatMessage.RoleEnum.User,   myFiltFinal  )
                    }
                ); 

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtboxInput.Text!="" & txtBoxPrompts.Text!="")
            {
                dictionary[txtBoxPrompts.Text] = txtboxInput.Text;

            }      
            FillListBox();
            SaveListBoxToXml();
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

        private void listBoxPrompt_SelectedIndexChanged(object sender, EventArgs e)
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

        private void bdDeletePrompt_Click(object sender, EventArgs e)
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

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

            string searchTerm = e.Url.ToString().ToLower();
            bool contains = searchTerm.Contains("about");
            bool containsblank = searchTerm.Contains("about:blank");

            if (!contains)
            {
                System.Diagnostics.Process.Start(e.Url.ToString());
                e.Cancel = true;
            }      
            else if(!containsblank) e.Cancel = true;           

        }
    }
}
