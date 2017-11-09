﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

/* 
 * Author: ChJees
 * Created: 2017-09-23
 */

namespace AbilityUserAI
{
    /// <summary>
    /// Do our caster have a enemy target?
    /// </summary>
    public class AbilityDecisionConditionalNode_HasEnemyTarget : AbilityDecisionNode
    {
        public override bool CanContinueTraversing(Pawn caster)
        {
            bool result = caster.mindState.enemyTarget != null;

            if (invert)
                return !result;

            return result;
        }
    }
}
