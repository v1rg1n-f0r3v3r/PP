using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace PP.Model
{
    public class ServerCollection : IListReceiver
    {
        int count = 0;
        public ServerCollection()
        {
            count = 1;
        }

        public List<object> LoadCollection()
        {
            List<object> servers = new List<object>();
            for (int i = 1; i < count; i++)
            {
                Server server = new Server();
                server.Ip = "1.1.1.1";
                server.Name = "Server " +i;
                server.Protocol = "STP";
                server.TypeConnection = "The beauty of the sunset was obscured by the industrial cranes. Ghosts dots cherry Blinky Pac-Man Power Pellets fruit. Key Crybaby slow guy maze dots Power Pellets flash Midway chaser Pinky cherry Puck Man ghosts. Shadow dots strawberry Pac-Man Midway chaser Pinky kill screen. She was disgusted he couldn’t tell the difference between lemonade and limeade. He had a hidden stash underneath the floorboards in the back room of the house. I think I will buy the red car, or I will lease the blue one. She had the gift of being able to paint songs. Don't put peanut butter on the dog's nose. Pac-Man Inky bashfull orange dots blue enemies ghosts Toru Iwatani Puck Man power up. She learned that water bottles are no longer just to hold liquid, but they're also status symbols. Fluffy pink unicorns are a popular status symbol among macho men. Orange fickle blue guy maze chase.\r\n\r\nShadow dots strawberry Pac-Man Midway chaser Pinky kill screen. He had a hidden stash underneath the floorboards in the back room of the house. Key Crybaby slow guy maze dots Power Pellets flash Midway chaser Pinky cherry Puck Man ghosts. I hear that Nancy is very pretty. Apple Speedy maze wocka wocka flash chase Pakkuman paku-paku dots pizza missing slice. Fluffy pink unicorns are a popular status symbol among macho men. As she walked along the street and looked in the gutter, she realized facemasks had become the new cigarette butts. He hated that he loved what she hated about hate. Patricia loves the sound of nails strongly pressed against the chalkboard. The old apple revels in its authority. High score Feigned Ignorance maze lives video game Apple slow guy chaser pizza missing slice dots blue. Arcade cabinets retro Melon dots maza Pac-Man chase red Namco fruit wocka paku-paku 1980. Ghosts dots cherry Blinky Pac-Man Power Pellets fruit.\r\n\r\nShe was disgusted he couldn’t tell the difference between lemonade and limeade. Apple Speedy maze wocka wocka flash chase Pakkuman paku-paku dots pizza missing slice. As she walked along the street and looked in the gutter, she realized facemasks had become the new cigarette butts. Fluffy pink unicorns are a popular status symbol among macho men. Ambusher maze wocka wocka fruit Pac-Man Fever arcade Galaxian Boss power up intermission. Key Crybaby slow guy maze dots Power Pellets flash Midway chaser Pinky cherry Puck Man ghosts. Arcade cabinets retro Melon dots maza Pac-Man chase red Namco fruit wocka paku-paku 1980. He was willing to find the depths of the rabbit hole in order to be with her. Poison ivy grew through the fence they said was impenetrable. She had the gift of being able to paint songs. Patricia loves the sound of nails strongly pressed against the chalkboard.\r\n\r\nGhosts dots cherry Blinky Pac-Man Power Pellets fruit. He was willing to find the depths of the rabbit hole in order to be with her. Don't put peanut butter on the dog's nose. Key Crybaby slow guy maze dots Power Pellets flash Midway chaser Pinky cherry Puck Man ghosts. She was disgusted he couldn’t tell the difference between lemonade and limeade. Apple Speedy maze wocka wocka flash chase Pakkuman paku-paku dots pizza missing slice. He hated that he loved what she hated about hate. Ambusher maze wocka wocka fruit Pac-Man Fever arcade Galaxian Boss power up intermission. Poison ivy grew through the fence they said was impenetrable. She learned that water bottles are no longer just to hold liquid, but they're also status symbols. Shadow pink ghosts kill screen yellow disk video game maze console power up dots Midway. High score Feigned Ignorance maze lives video game Apple slow guy chaser pizza missing slice dots blue. Fluffy pink unicorns are a popular status symbol among macho men.";
                server.Port   = i.ToString();
                var random = new Random();
                var randomBool = random.Next(2) == 1;
                server.IsCat = randomBool;
                server.IsGood = randomBool;
                server.IsBad = randomBool;
                server.IsAlive = randomBool;
                servers.Add(server);
                Thread.Sleep(10);
            }
            return servers;
        }
    }
}
