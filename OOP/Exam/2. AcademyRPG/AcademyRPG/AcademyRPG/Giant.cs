﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    //public class Giant : Character, IGatherer ,IFighter
    //{
    //    public Giant(string name, Point position) : base(name, position,0)
    //    {
    //        this.HitPoints = 200;
    //    }

    //    private bool hasGatherStoneOne = false;

    //    public bool TryGather(IResource resource)
    //    {
    //        if (resource.Type == ResourceType.Stone)
    //        {
    //            if (!this.hasGatherStoneOne)
    //            {
    //                this.AttackPoints += 100;
    //                this.hasGatherStoneOne = true;
    //            }
    //            return true;
    //        }

    //        return false;
    //    }

    //    private int attackPoints = 150;

    //    public int AttackPoints
    //    {
    //        get
    //        {
    //            return this.attackPoints;
    //        }
    //        private set
    //        {
    //            this.attackPoints = value;
    //        }
    //    }

    //    public int DefensePoints
    //    {
    //        get
    //        {
    //            return 80;
    //        }
    //    }

    //    public int GetTargetIndex(List<WorldObject> availableTargets)
    //    {
    //        for (int i = 0; i < availableTargets.Count; i++)
    //        {
    //            if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
    //            {
    //                return i;
    //            }
    //        }

    //        return -1;
    //    }
    //}
}