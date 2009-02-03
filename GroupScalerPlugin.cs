using System;
using System.Windows.Forms;
using TD.SandBar;
using NWN2Toolset;
using NWN2Toolset.Plugins;
using NWN2Toolset.NWN2;
using NWN2Toolset.NWN2.Views;
using NWN2Toolset.NWN2.Data.Instances;
using Microsoft.DirectX;

namespace GroupScaler
{
    public class GroupScalerPlugin : INWN2Plugin
    {
        private MenuButtonItem m_cMenuItem;

        private void HandlePluginLaunch(object sender, EventArgs e)
        {
            NWN2AreaViewer activeViewer = (NWN2ToolsetMainForm.App.GetActiveViewer() as NWN2AreaViewer);
            if (activeViewer == null || activeViewer.SelectedInstances.Count <= 0)
            {
                MessageBox.Show("No selection", DisplayName, MessageBoxButtons.OK);
                return;
            }

            using (ScaleForm frm = new ScaleForm())
            {
                DialogResult res = frm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    float scaleFactor = frm.ScaleFactor;

                    Vector3 center = new Vector3(0f, 0f, 0f);
                    int count = 0;
                    foreach (INWN2Instance instance in activeViewer.SelectedInstances)
                    {
                        if (instance.Area == null) continue;

                        if (instance is NWN2CreatureInstance)
                        {
                            center.Add((instance as NWN2CreatureInstance).Position);
                            count++;
                        }
                        if (instance is NWN2DoorInstance)
                        {
                            center.Add((instance as NWN2DoorInstance).Position);
                            count++;
                        }
                        if (instance is NWN2EncounterInstance)
                        {
                            center.Add((instance as NWN2EncounterInstance).Position);
                            count++;
                        }
                        if (instance is NWN2EnvironmentInstance)
                        {
                            center.Add((instance as NWN2EnvironmentInstance).Position);
                            count++;
                        }
                        if (instance is NWN2ItemInstance)
                        {
                            center.Add((instance as NWN2ItemInstance).Position);
                            count++;
                        }
                        if (instance is NWN2LightInstance)
                        {
                            center.Add((instance as NWN2LightInstance).Position);
                            count++;
                        }
                        if (instance is NWN2PlaceableInstance)
                        {
                            center.Add((instance as NWN2PlaceableInstance).Position);
                            count++;
                        }
                        if (instance is NWN2PlacedEffectInstance)
                        {
                            center.Add((instance as NWN2PlacedEffectInstance).Position);
                            count++;
                        }
                        if (instance is NWN2SoundInstance)
                        {
                            center.Add((instance as NWN2SoundInstance).Position);
                            count++;
                        }
                        if (instance is NWN2StaticCameraInstance)
                        {
                            center.Add((instance as NWN2StaticCameraInstance).Position);
                            count++;
                        }
                        if (instance is NWN2StoreInstance)
                        {
                            center.Add((instance as NWN2StoreInstance).Position);
                            count++;
                        }
                        if (instance is NWN2TreeInstance)
                        {
                            center.Add((instance as NWN2TreeInstance).Position);
                            count++;
                        }
                        if (instance is NWN2TriggerInstance)
                        {
                            center.Add((instance as NWN2TriggerInstance).Position);
                            count++;
                        }
                        if (instance is NWN2WaypointInstance)
                        {
                            center.Add((instance as NWN2WaypointInstance).Position);
                            count++;
                        }
                    }
                    center.Multiply(1.0f / Convert.ToSingle(count));
                    foreach (INWN2Instance instance in activeViewer.SelectedInstances)
                    {
                        if (instance.Area == null) continue;

                        Vector3 position = new Vector3(0f, 0f, 0f);
                        Vector3 scale = new Vector3(0f, 0f, 0f);
                        if (instance is NWN2CreatureInstance)
                        {
                            position = (instance as NWN2CreatureInstance).Position;
                            scale = (instance as NWN2CreatureInstance).Scale;
                        }
                        if (instance is NWN2DoorInstance)
                        {
                            position = (instance as NWN2DoorInstance).Position;
                            scale = (instance as NWN2DoorInstance).Scale;
                        }
                        if (instance is NWN2EncounterInstance)
                        {
                            position = (instance as NWN2EncounterInstance).Position;
                            // TODO scale Geometry and SpawnPoints
                        }
                        if (instance is NWN2EnvironmentInstance)
                        {
                            position = (instance as NWN2EnvironmentInstance).Position;
                            scale = (instance as NWN2EnvironmentInstance).Scale;
                        }
                        if (instance is NWN2ItemInstance)
                        {
                            position = (instance as NWN2ItemInstance).Position;
                        }
                        if (instance is NWN2LightInstance)
                        {
                            position = (instance as NWN2LightInstance).Position;
                        }
                        if (instance is NWN2PlaceableInstance)
                        {
                            position = (instance as NWN2PlaceableInstance).Position;
                            scale = (instance as NWN2PlaceableInstance).Scale;
                        }
                        if (instance is NWN2PlacedEffectInstance)
                        {
                            position = (instance as NWN2PlacedEffectInstance).Position;
                        }
                        if (instance is NWN2SoundInstance)
                        {
                            position = (instance as NWN2SoundInstance).Position;
                        }
                        if (instance is NWN2StaticCameraInstance)
                        {
                            position = (instance as NWN2StaticCameraInstance).Position;
                        }
                        if (instance is NWN2StoreInstance)
                        {
                            position = (instance as NWN2StoreInstance).Position;
                        }
                        if (instance is NWN2TreeInstance)
                        {
                            position = (instance as NWN2TreeInstance).Position;
                            scale = (instance as NWN2TreeInstance).Scale;
                        }
                        if (instance is NWN2TriggerInstance)
                        {
                            position = (instance as NWN2TriggerInstance).Position;
                            // TODO scale Geometry
                        }
                        if (instance is NWN2WaypointInstance)
                        {
                            position = (instance as NWN2WaypointInstance).Position;
                        }
                        position.Subtract(center);
                        position.Scale(scaleFactor);
                        position.Add(center);
                        scale.Multiply(scaleFactor);
                        if (instance is NWN2CreatureInstance)
                        {
                            (instance as NWN2CreatureInstance).Position = position;
                            (instance as NWN2CreatureInstance).Scale = scale;
                        }
                        if (instance is NWN2DoorInstance)
                        {
                            (instance as NWN2DoorInstance).Position = position;
                            (instance as NWN2DoorInstance).Scale = scale;
                        }
                        if (instance is NWN2EncounterInstance)
                        {
                            (instance as NWN2EncounterInstance).Position = position;
                        }
                        if (instance is NWN2EnvironmentInstance)
                        {
                            (instance as NWN2EnvironmentInstance).Position = position;
                            (instance as NWN2EnvironmentInstance).Scale = scale;
                        }
                        if (instance is NWN2ItemInstance)
                        {
                            (instance as NWN2ItemInstance).Position = position;
                        }
                        if (instance is NWN2LightInstance)
                        {
                            (instance as NWN2LightInstance).Position = position;
                        }
                        if (instance is NWN2PlaceableInstance)
                        {
                            (instance as NWN2PlaceableInstance).Position = position;
                            (instance as NWN2PlaceableInstance).Scale = scale;
                        }
                        if (instance is NWN2PlacedEffectInstance)
                        {
                            (instance as NWN2PlacedEffectInstance).Position = position;
                        }
                        if (instance is NWN2SoundInstance)
                        {
                            (instance as NWN2SoundInstance).Position = position;
                        }
                        if (instance is NWN2StaticCameraInstance)
                        {
                            (instance as NWN2StaticCameraInstance).Position = position;
                        }
                        if (instance is NWN2StoreInstance)
                        {
                            (instance as NWN2StoreInstance).Position = position;
                        }
                        if (instance is NWN2TreeInstance)
                        {
                            (instance as NWN2TreeInstance).Position = position;
                            (instance as NWN2TreeInstance).Scale = scale;
                        }
                        if (instance is NWN2TriggerInstance)
                        {
                            (instance as NWN2TriggerInstance).Position = position;
                        }
                        if (instance is NWN2WaypointInstance)
                        {
                            (instance as NWN2WaypointInstance).Position = position;
                        }
                    }
                }
            }
        }

        public void Load(INWN2PluginHost cHost)
        {
        }

        public void Shutdown(INWN2PluginHost cHost)
        {
        }

        public void Startup(INWN2PluginHost cHost)
        {
            m_cMenuItem = cHost.GetMenuForPlugin(this);
            m_cMenuItem.Activate += new EventHandler(this.HandlePluginLaunch);
        }

        public void Unload(INWN2PluginHost cHost)
        {
        }

        public MenuButtonItem PluginMenuItem
        {
            get
            {
                return m_cMenuItem;
            }
        }

        public string DisplayName
        {
            get
            {
                return "Group Scaler";
            }
        }

        public string MenuName
        {
            get
            {
                return "Group Scaler";
            }
        }

        public string Name
        {
            get
            {
                return "GroupScaler";
            }
        }

        public object Preferences
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

    }
}
