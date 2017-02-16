using Nancy;
using System;
using System.Collections.Generic;
using Scrabble.Objects;

namespace Scrabble
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["index.cshtml"];

            Post["/move_form"] = _ => {
                ScrabbleApp obj = new ScrabbleApp();
                int output = obj.MoveScore(Request.Form["playerMove"]);
                return View["index.cshtml", output];
            };

        }
    }
}
