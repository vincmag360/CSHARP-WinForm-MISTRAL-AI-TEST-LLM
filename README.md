![C#](https://img.shields.io/badge/Just%20for%20test-Enjoy%20!-blue) [![C#](https://img.shields.io/badge/WINFORM-8A2BE2)](https://fr.wikipedia.org/wiki/Windows_Forms)  [![C#](https://img.shields.io/badge/Language-CSharp-darkgreen.svg)](https://en.wikipedia.org/wiki/C_Sharp_(programming_language))  [![License: MIT](https://img.shields.io/github/license/VINCMAG360/CSHARP-WinForm-MISTRAL-AI-TEST-LLM)](https://github.com/vincmag360/CSHARP-WinForm-MISTRAL-AI-TEST-LLM/blob/master/LICENSE.txt)
[![Downloads](https://img.shields.io/github/downloads/vincmag360/CSHARP-WinForm-MISTRAL-AI-TEST-LLM/total.svg "Downloads")](https://github.com/vincmag360/CSHARP-WinForm-MISTRAL-AI-TEST-LLM/releases)
# This is a simple Windows application in WinForm to test the Mistral AI LLM.


## Mistral.SDK Usage
This application utilizes the Mistral.SDK, an unofficial C# client designed for interacting with the Mistral API. https://github.com/tghamm/Mistral.SDK

## Application Features
This application facilitates interaction with the various AI models offered by Mistral AI. It also features a straightforward management system for Prompts.

## Response Format
- The response format used in this application is "text," but it is possible to use JSON in the code. See the Mistral API: Enum: "text" "json_object". JSON allows you to have a formatted response and exploit it to create a rich graphical response or have interesting actions.
- The output is in HTML format (conversion of markdown txt to HTML).
- Code examples are displayed in a blue frame in the HTML response.

## API Documentation
Mistral AI API documentation: https://docs.mistral.ai/api/#tag/chat

## Experimentation with Mistral AI
Experimentation with Mistral AI is free and does not require providing a payment method. In return, Mistral AI reserves the right to exploit the input and output data, as well as the prompts.

  
## Limits

- The usage limits to remember in November 2024, valid for all models except Embed: 1 request per second, 500,000 tokens per minute, and 1 billion tokens per month.
  https://console.mistral.ai/limits/
- Tokenization  : https://docs.mistral.ai/guides/tokenization/

## API Key

- To get started, create a Mistral account https://mistral.ai/ or sign in at console.mistral.ai.
- After that, go to the API keys page and make a new API key by clicking Create new key. 
- Make sure to copy the API key, save it safely, :warning: and do not share it with anyone.
- Put the API key in the file fichier.xml between `<Key></Key> `

## fichier.xml

In this file, it is possible to :

* :pushpin:**Set the API Keys from your Mistral account**
 `<Key>BLABLABLA</Key> `
* :pushpin:**Set the rendering of the response in CSS**
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
* :pushpin:**Set the background color of the rendering**
`<KeyBACK>white</KeyBACK>`
* :pushpin:**Set the default rendering model of the Mistral LLM**
`<KeyModelDefault>pixtral-large-latest</KeyModelDefault>`
  

## :star:Is This the End of Web Browsers ?

- No use of a web browser.
- Your Internet service provider does not see your activity.
- Google is not spying on you!
- Quick opening.
- Portability, no need for setup.
- Management of prompts.

![alt text](https://repository-images.githubusercontent.com/894515713/9c722373-1636-4aca-a4bb-b56c60a7637f)

<a href="#top">Back to top</a>
