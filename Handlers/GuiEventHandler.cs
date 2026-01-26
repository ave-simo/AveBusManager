using System;

/*
 * this class is responsible of the interaction 
 * with the gui from an external process
 */

namespace AveBusManager
{
    internal class GuiEventHandler
    {

        private MainForm mainForm;

        public GuiEventHandler(MainForm mainForm) 
        {
            this.mainForm = mainForm;
        }



        public void guiUpdate(string eventKey, string eventValue)
        {

            if (mainForm.InvokeRequired)
            {
                mainForm.BeginInvoke(new Action(() => guiUpdate(eventKey, eventValue)));
                return;
            }

            switch (eventKey)
            {
                case "LIGHT_STATUS":
                    if (eventValue.Equals("TURN_ON_LIGHT_1_FRAME_COMMAND"))  mainForm.changeLight1StatusColor("yellow");
                    if (eventValue.Equals("TURN_OFF_LIGHT_1_FRAME_COMMAND")) mainForm.changeLight1StatusColor("black");
                    if (eventValue.Equals("TURN_ON_LIGHT_2_FRAME_COMMAND"))  mainForm.changeLight2StatusColor("yellow");
                    if (eventValue.Equals("TURN_OFF_LIGHT_2_FRAME_COMMAND")) mainForm.changeLight2StatusColor("black");
                    if (eventValue.Equals("CHANGE_LIGHT_STATUS_FRAME_COMMAND")) {}
                    break;

                case "PRINT_LOG":
                    mainForm.AppendLog(eventValue);
                    break;

                case "CHANGE_BACKGROUND_COLOR":
                    mainForm.changeBackGroundColor(eventValue);
                    break;

                default:
                    break;
            }
        }

    }
}
