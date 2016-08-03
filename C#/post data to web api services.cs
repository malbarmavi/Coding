

string url = "http://www.api.mbarmawi.com/";
string value = "{ 'FirstName':'MUhammad Albarmawi','Address':'Syria,Daraa'}";
WebClient wc = GetWebClient();
wc.Headers[HttpRequestHeader.ContentType] = "application / json";
return wc.UploadString(url, "POST", value);