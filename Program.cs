using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18_과제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //과제1,2
            //Player player = new Player();
            //FortificationNpc fortificationNpc = new FortificationNpc();
            //WarehouseNpc warehouseNpc = new WarehouseNpc(); 
            //JobNpc jobNpc = new JobNpc();

            //player.InteractWithNPC(fortificationNpc);
            //player.InteractWithNPC(warehouseNpc);
            //player.InteractWithNPC(jobNpc);

            //심화
            Player player = new Player();
            FortificationNpc fortificationNpc = new FortificationNpc();
            WarehouseNpc warehouseNpc = new WarehouseNpc();
            JobNpc jobNpc = new JobNpc();
            NPC[] TotalNpc = new NPC[3];

            TotalNpc[0] = fortificationNpc;
            TotalNpc[1] = warehouseNpc;
            TotalNpc[2] = jobNpc;   

            fortificationNpc.posX = 3;
            fortificationNpc.NpcName = "강화npc";
            warehouseNpc.posX = 7;
            warehouseNpc.NpcName = "창고npc";
            jobNpc.posX = 12;
            jobNpc.NpcName = "잡npc";

            player.ShowInteractable(TotalNpc);
           




        }
    }
}
