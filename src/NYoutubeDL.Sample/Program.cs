// Copyright 2021 Brian Allred
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

namespace NYoutubeDL.Sample
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Helpers;
    using NYoutubeDL.Models;
    using Options;

    #endregion

    public class Program
    {
        public static void Main(string[] args)
        {
            YoutubeDL ytd = new YoutubeDL();
            ytd.Options.GeneralOptions.FlatPlaylist = true;
            ytd.Options.VideoSelectionOptions.PlaylistItems = "1";
            ytd.Options.VerbositySimulationOptions.PrintField = "url";
            ytd.StandardErrorEvent += (sender, error) => Console.WriteLine(error);
            ytd.StandardOutputEvent += (sender, output) => Console.WriteLine(output);
            Console.WriteLine("\n\n\n");
            ytd.Download("https://www.youtube.com/results?search_query=critical+breakdown&sp=EgIQAg%253D%253D");

        }
    }
}