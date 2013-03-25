using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    //public class Ninja : Character, IGatherer, IFighter
    //{
    //    public Ninja(string name, Point position, int owner) : base(name, position, owner)
    //    {
    //        this.HitPoints = 1;
    //        this.AttackPoints = 0;
           
    //    }

    //    public bool TryGather(IResource resource)
    //    {
    //        if ((resource.Type == ResourceType.Stone) || (resource.Type == ResourceType.Lumber))
    //        {
    //            this.AttackPoints += resource.Quantity * 2;
    //            return true;
    //        }
    //        return false;
    //    }

    //    public int DefensePoints
    //    {
    //        get { return 0; }
    //    }
    //    public bool IsDestroyed
    //    {
    //        get
    //        {
    //            return false;
    //        }
    //    }

    //    private int attackPoints;

    //    public int AttackPoints
    //    {
    //        get
    //        {
    //            return attackPoints;
    //        }
    //        set
    //        {
    //            attackPoints = value;
    //        }
    //    }

    //    public int GetTargetIndex(List<WorldObject> availableTargets)
    //    {
    //        for (int i = 0; i < availableTargets.Count; i++)
    //        {
    //            var highestPlayers = from player in availableTargets
    //                                 orderby player.HitPoints ascending
    //                                 select player;
                
    //            if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0 &&
    //                highestPlayers.First() == availableTargets[i])
    //            {
    //                return i;
    //            }
    //        }

    //        return -1;
    //    }
    //}
}