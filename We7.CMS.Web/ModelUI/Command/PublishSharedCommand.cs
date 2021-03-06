﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using We7.Model.Core;
using System.Collections.Generic;
using We7.CMS.Common;
using We7.Model.UI.Data;
using We7.CMS;

namespace We7.Model.UI.Command
{
    public class PublishSharedCommand : BaseCommand
    {
        public override object Do(PanelContext data)
        {
            List<DataKey> dataKeys = data.State as List<DataKey>;
            if (dataKeys != null)
            {
                ShareEventFactory.Instance.OnPublishSharedCommand(dataKeys);
            }
            return null;
        }
    }
}
