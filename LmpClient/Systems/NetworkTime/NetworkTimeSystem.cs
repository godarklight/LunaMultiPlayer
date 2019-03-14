using LmpClient.Base;

namespace LmpClient.Systems.NetworkTime
{
    public class NetworkTimeSystem : MessageSystem<NetworkTimeSystem, NetworkTimeMessageSender, NetworkTimeMessageHandler>
    {
        public override string SystemName { get; } = nameof(NetworkTimeSystem);

        protected override bool ProcessMessagesInUnityThread => false;

        protected override void OnEnabled()
        {
            base.OnEnabled();
            //Send networktime message every 30 seconds
            SetupRoutine(new RoutineDefinition(30000, RoutineExecution.Update, Singleton.MessageSender.SendNetworkTimeRequest));
        }

        protected override void OnDisabled()
        {
            base.OnDisabled();
        }
    }
}
