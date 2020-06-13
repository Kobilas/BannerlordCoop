﻿using Sync;
using TaleWorlds.CampaignSystem;

namespace Coop.Mod.Persistence
{
    public interface IEnvironmentServer
    {
        FieldAccessGroup<MobileParty, MovementData> TargetPosition { get; }
        bool CanChangeTimeControlMode { get; }
        MobileParty GetMobilePartyByIndex(int iPartyIndex);
        Campaign GetCurrentCampaign();
    }
}
