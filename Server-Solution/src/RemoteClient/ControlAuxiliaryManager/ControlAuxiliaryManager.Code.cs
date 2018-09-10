using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RemoteClient
{
    public delegate void ControlAuxiliaryManagerPressEnter(object sender, KeyEventArgs e);

    partial class ControlAuxiliaryManager
    {
        #region Class Event Declarations
        public event ControlAuxiliaryManagerPressEnter OnPressEnter;
        #endregion

        #region Class Constructor
        public ControlAuxiliaryManager() {}        
        #endregion

        #region Class Event Void Procedures

        //#####################################CLASS ControlStudentManager EVENTS#######################################
        //event is raised when the class is loaded
        protected override void ClassLoad(object sender, EventArgs e)
        {
            base.ClassLoad(sender, e);

            _maxHeight = this.Size.Height;

        } //----------------------------
        //####################################END CLASS ControlStudentManager EVENTS####################################

        //###################################TEXTBOX txtSearch EVENTS##########################################
        //event is raised when the key is up
        protected override void txtSearchKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ControlAuxiliaryManagerPressEnter ev = OnPressEnter;

                if (ev != null)
                {
                    OnPressEnter(sender, e);
                }
            }
            else
            {
                base.txtSearchKeyUp(sender, e);
            }

        }
        //#################################END TEXTBOX txtSearch EVENTS########################################
        #endregion
    }
}