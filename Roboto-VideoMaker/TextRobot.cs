using System;
using System.Collections.Generic;
using System.Text;
using Algorithmia;

namespace Roboto_VideoMaker
{
    class TextRobot
    {
        public TextRobot(UserInput userInput)
        {
            var wikipediaContent = fetchContentFromWikipedia(userInput);

        }

        private AlgorithmResponse fetchContentFromWikipedia(UserInput userInput)
        {
            var input = "{"
            + string.Format("  \"articleName\": \"{0}\",", userInput.SearchTerm)
            + "  \"lang\": \"en\""
            + "}";
            var client = new Client("simFbVPFVpU4/ACpWnMDWQ94Jxn1");
            var algorithm = client.algo("web/WikipediaParser/0.1.2");
            algorithm.setOptions(timeout: 300); // optional timeout
            var response = algorithm.pipeJson<object>(input);
            Console.Write(response.result);
            return response;
        }

        private void CleanContentReceived(AlgorithmResponse content)
        {

        }
        private void BreakContentIntoSentences(AlgorithmResponse content)
        {

        }
    }
}
