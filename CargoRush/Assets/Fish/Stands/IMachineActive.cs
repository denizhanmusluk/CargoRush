using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMachineActive
{
    void MachineErrored();
    void MachineRepaired();
    bool errorActive { get; set; }
}
