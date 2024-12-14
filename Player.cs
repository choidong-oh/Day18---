using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18_과제
{
    internal class Player
    {
        int PlayerposX =5;

        public void InteractWithNPC(IInteractable npc)
        {
            npc.Interact();
        }

        public void ShowInteractable(NPC[] totalnpc)
        {
            for (int i = 0; i < totalnpc.Length; i++)
            {
                //절댓값(npc위치-player위치)<5
                if (Math.Abs(totalnpc[i].posX- PlayerposX)<5)
                {
                    Console.WriteLine(totalnpc[i].NpcName);
                }
            }
        }




    }
}
