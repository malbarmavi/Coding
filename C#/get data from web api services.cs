

WebClient wc = new WebClient();
wc.Encoding = Encoding.UTF8;
wc.QueryString.Add("parameter", value);
wc.DownloadString(uri);