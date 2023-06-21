using Vintagestory.API.Client;

namespace WaypointTogether;

public class Client {
    public readonly ClientNetwork network;

    public Client(ICoreClientAPI api) {
        network = new ClientNetwork(api);
    }
}
