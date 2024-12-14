using Day18_과제;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18_과제
{
    interface IInteractable
    {
        void Interact();
    }
    class FortificationNpc : NPC, IInteractable
    {
        public void Interact()
        {
            Console.WriteLine("강화npc");
        }
    }


    class WarehouseNpc : NPC, IInteractable
    {
        public void Interact()
        {
            Console.WriteLine("창고npc");
        }

    }
    class JobNpc : NPC
    {
        public void Interact()
        {
            Console.WriteLine("잡npc");
        }
        
    }





    abstract class NPC 
    {
        public int posX;
        public string NpcName;

        



    }
}
