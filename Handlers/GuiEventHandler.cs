using System;

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
                    if (eventValue.Equals("TURN_ON_LIGHT_1_FRAME_COMMAND"))
                    {
                        mainForm.changeLight1StatusColor("yellow");
                    }

                    if (eventValue.Equals("TURN_OFF_LIGHT_1_FRAME_COMMAND"))
                    {
                        mainForm.changeLight1StatusColor("black");
                    }

                    if (eventValue.Equals("CHANGE_LIGHT_STATUS_FRAME_COMMAND"))
                    {
                        // TODO
                        // check color
                            // if yellow -> paint it black <3
                            // if black  -> paint it yellow
                    }

                    // la luce due non ci piace e non la gestiamo

                    break;

                case "PRINT_LOG":
                    mainForm.AppendLog(eventValue);
                    break;

                default:
                    break;
            }
        }

    }
}
