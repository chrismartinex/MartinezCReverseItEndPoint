//Chris Martinez
//10/27/22
//Reverse It - End Point Challenge
//https://localhost:****/reversethis/regress/
//Peer Review by Carlos Felipe : This code reverses anything I put into it. It does it flawlessly even with numbers and weird characters. Good job.

using Microsoft.AspNetCore.Mvc;

namespace MartinezCReverseItEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseThisController : ControllerBase
{
 [HttpGet]
 [Route("Regress/{wordsOut}")]
 public string functionName( string wordsOut)
 {

  string result = "";
  int num = 0;
  bool verifyNum = Int32.TryParse(wordsOut, out num);
  if (!verifyNum)
  {
   for (int i = wordsOut.Length - 1; i >= 0; i--)
   {
    result += wordsOut[i];
   }
   result = $"{result}";
  }
  else if (verifyNum)
  {
   int reverse = 0;
   int leftover = 0;
   while (num > 0)
   {
    leftover = num % 10;
    reverse = (reverse * 10) + leftover;
    num = num / 10;
   }
   result = $"{reverse}";
  }
  return result;
 }

}


