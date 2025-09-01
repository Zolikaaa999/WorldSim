namespace WorldSim.Simulation;

public class EnvironmentSensor : Sensor
{
    public override void Sense(World world, Person person, Blackboard blackboard)
    {
        var tile = world.GetTile(person.Pos.x, person.Pos.y);
        var node = tile.Node;
        if (node != null)
        {
            // Jel�ld le, hogy ezen a tile-on milyen resource van (poz�ci�val egy�tt)
            blackboard.Add(new FactualEvent(EventTypes.ResourceHere, node.Type, person.Pos));
        }
    }
}
