using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace sandc_paint_pfs
{
    public class GridClass
    {
        [JsonProperty("edit_item")]
        public string edit_item;
        [JsonProperty("emp_no_hang")]
        public string emp_no_hang;
        [JsonProperty("job_order_no")]
        public string job_order_no;
        [JsonProperty("nmr_no")]
        public string nmr_no;
        [JsonProperty("sequence_no")]
        public string sequence_no;
        [JsonProperty("part_no")]
        public string part_no;
        [JsonProperty("value_stream_id")]
        public string value_stream_id;
        [JsonProperty("paint_color")]
        public string paint_color;
        [JsonProperty("qty_hung")]
        public string qty_hung;
        [JsonProperty("dt_hang")]
        public string dt_hang;
        [JsonProperty("emp_no_takedown")]
        public string emp_no_takedown;
        [JsonProperty("qty_good")]
        public string qty_good;
        [JsonProperty("qty_rejected")]
        public string qty_rejected;
        [JsonProperty("rejection_code")]
        public string rejection_code;
        [JsonProperty("rejection_notes")]
        public string rejection_notes;
        [JsonProperty("dt_takedown")]
        public string dt_takedown;
        [JsonProperty("emp_no_transaction")]
        public string emp_no_transaction;
        [JsonProperty("transaction_type_id")]
        public string transaction_type_id;
        [JsonProperty("qty_complete")]
        public string qty_complete;
        [JsonProperty("qty_moved")]
        public string qty_moved;
        [JsonProperty("dt_transaction")]
        public string dt_transaction;
        [JsonProperty("rework")]
        public string rework;
        [JsonProperty("reject_location")]
        public string reject_location;
    }
    public class GridPaintTrackerData
    {
        public static GridClass[] GetPaintTrackerData(DataSet ds)
        {
            ArrayList rows = new ArrayList();
            try
            {
                if (ds.Tables["table_results"].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables["table_results"].Rows)
                    {

                        GridClass obj = new GridClass();
                        string details_url = "report_recent_painted_results_view.aspx?type=report_recent_painted&auto_id=" + row["auto_id"].ToString();
                        //if (Cookies_Helper.GetEmployeeLoggedInIsSupervisor().ToLower() == "yes")
                        //{
                        //    obj.edit_item = "<span onclick = \"open_paint_tracker_modal( '" + details_url + "','" + row["auto_id"].ToString() + "')\"><i class=\"fa fa-pencil\"></i></span>";
                        //}
                        //else
                        //{
                        //    obj.edit_item = "";
                        //}
                        obj.edit_item = "<span onclick = \"open_paint_tracker_modal( '" + details_url + "','" + row["auto_id"].ToString() + "')\"><i class=\"fa fa-pencil\"></i></span>";
                        obj.emp_no_hang = row["emp_no_hang"].ToString();
                        obj.job_order_no = row["job_order_no"].ToString();
                        obj.nmr_no = row["nmr_no"].ToString();
                        obj.sequence_no = row["sequence_no"].ToString();
                        obj.part_no = row["part_no"].ToString();
                        obj.value_stream_id = row["value_stream_id"].ToString();
                        obj.paint_color = row["paint_color"].ToString();
                        obj.qty_hung = row["qty_hung"].ToString();
                        obj.dt_hang = Convert.ToDateTime(row["dt_hang"].ToString()).ToString("yyyy-MM-dd  HH:mm:ss");
                        obj.emp_no_takedown = row["emp_no_takedown"].ToString();
                        obj.qty_good = row["qty_good"].ToString();
                        obj.qty_rejected = row["qty_rejected"].ToString();
                        obj.rejection_code = row["rejection_code"].ToString();
                        obj.rejection_notes = row["rejection_notes"].ToString();
                        obj.dt_takedown = Convert.ToDateTime(row["dt_takedown"].ToString()).ToString("yyyy-MM-dd  HH:mm:ss");
                        obj.emp_no_transaction = row["emp_no_transaction"].ToString();
                        obj.transaction_type_id = row["transaction_type_id"].ToString();
                        obj.qty_complete = row["qty_complete"].ToString();
                        obj.qty_moved = row["qty_moved"].ToString();
                        obj.dt_transaction = row["dt_transaction"].ToString();
                        obj.reject_location = row["reject_location"].ToString();
                        obj.rework = row["rework"].ToString();
                        rows.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            GridClass[] arrReturn = (GridClass[])rows.ToArray(typeof(GridClass));
            return arrReturn;
        }
    }
}
