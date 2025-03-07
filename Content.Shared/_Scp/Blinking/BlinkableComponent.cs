﻿using Content.Shared.Alert;
using Content.Shared.StatusIcon;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._Scp.Blinking;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class BlinkableComponent : Component
{
    [ViewVariables, AutoNetworkedField]
    public TimeSpan NextBlink;

    [ViewVariables, AutoNetworkedField]
    public TimeSpan BlinkEndTime;

    [ViewVariables, AutoNetworkedField]
    public float AdditionalBlinkingTime;

    [DataField]
    public ProtoId<BlinkIconPrototype> ClosedEyeIcon = "ClosedEyeIcon";

    [DataField]
    public ProtoId<AlertPrototype> BlinkingAlert = "Blinking";

}

[RegisterComponent, NetworkedComponent]
public sealed partial class ShowBlinkableComponent : Component
{
}
