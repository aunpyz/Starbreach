// Copyright (c) Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using Stride.Engine;

namespace Starbreach
{
    class StarbreachApp
    {
        static void Main(string[] args)
        {
            using (var game = new StarbreachGame())
            {
                game.Run();
            }
        }
    }
}
