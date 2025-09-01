using System.Collections.Generic;

namespace WorldSim.Simulation;

public class Memory
{
    private readonly List<FactualEvent> _events = new();
    public IReadOnlyList<FactualEvent> Events => _events;
    private readonly int _capacity = 2000; // egyszer� cap, hogy ne n�j�n v�gtelenre

    public void Remember(IEnumerable<FactualEvent> events)
    {
        _events.AddRange(events);
        if (_events.Count > _capacity)
        {
            int trim = _events.Count - _capacity;
            _events.RemoveRange(0, trim);
        }
    }
}
