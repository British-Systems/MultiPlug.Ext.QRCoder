using MultiPlug.Extension.Core;
using System;
using System.Collections.Generic;
using MultiPlug.Base.Exchange;
using MultiPlug.Extension.Core.Views;

namespace MultiPlug.Ext.QRCoder
{
    public class QRCoder : ExtensionBase
    {
        public override MultiPlugType<ViewBase[]> Apps
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override List<Event> Events
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override List<Subscription> Subscriptions
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override event EventHandler<MultiPlugType<ViewBase[]>> AppsUpdated;
        public override event EventHandler<List<Event>> EventsUpdated;
        public override event EventHandler<List<Subscription>> SubscriptionsUpdated;

        public override void Initialise()
        {
            throw new NotImplementedException();
        }

        public override void Load(KeyValuesJson[] config)
        {
            throw new NotImplementedException();
        }

        public override void OnUnhandledException(UnhandledExceptionEventArgs args)
        {
            throw new NotImplementedException();
        }

        public override object Save()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
