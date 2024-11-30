
# This is a simple Windows application in WinForm to test the Mistral AI LLM.


- This application use the Mistral.SDK an unofficial C# client designed for interacting with the Mistral API. : https://github.com/tghamm/Mistral.SDK
- This application facilitates interaction with the various AI models offered by Mistral AI.
It also features a straightforward management system for Prompts.

- The response format used in this application is "text" but it is possible to use json in the code.
See the Mistral API: Enum: "text" "json_object" . Json allows you to have a formatted response and exploit it to create a rich graphical response or have interesting actions.
  
- Mistral AI API documentation : https://docs.mistral.ai/api/#tag/chat

- MISTRAL AI experimentation is free and does not require providing a payment method.
  In return, Mistral AI reserves the right to exploit the input and output data, as well as the prompts
  
## Limits

- The usage limits to remember in November 2024, valid for all models except Embed: 1 request per second, 500,000 tokens per minute, and 1 billion tokens per month.
  https://console.mistral.ai/limits/
- Tokenization  : https://docs.mistral.ai/guides/tokenization/

## API Key

- To get started, create a Mistral account https://mistral.ai/ or sign in at console.mistral.ai.
- After that, go to the API keys page and make a new API key by clicking Create new key. 
- Make sure to copy the API key, save it safely, and do not share it with anyone.
- Put the API key in the file fichier.xml between `<Key></Key> `

## fichier.xml

In this file, it is possible to :

- Set the API Keys from your Mistral account.
 `<Key>BLABLABLA</Key> `

- Set the rendering of the response in CSS :
```
<KeyCCS>
h1 {color: #800080;}
h2 {color: #9f3981;}
h3 {color: #000000d9;}
h4 {color: #a3a2a0;}
h5 {color: #b9b7b7;}
h6 {color: #d2d7e2;}
</KeyCCS>
```
- Set the background color of the rendering.
  `<KeyBACK>white</KeyBACK>`
  
 - Set the default rendering model of the Mistral LLM
  `<KeyModelDefault>pixtral-large-latest</KeyModelDefault>`
  

## Is This the End of Web Browsers ?

![alt text](https://repository-images.githubusercontent.com/893368944/de21e980-7af8-49fd-90c8-9d2c36f375cc)

