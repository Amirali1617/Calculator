<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/amin8zamany/AuxiliaryLibraries">
    <img src="AuxiliaryLibraries_Logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">AuxiliaryLibraries</h3>
  <p align="left">
    This library helps you to get rid of some repetitive code blocks about date-times, IP, Rest, JSON, encryption, files, directories, queue, zip, objects, and string    extensions.
    <br />
     This is a good helper, and saves lots of time, especially for Iranian programmers.
    <br />
    <br />
  </p>
  <p align="center">
    <a href="https://www.nuget.org/packages/AuxiliaryLibraries/">Nuget Package >></a>
  </p>
</p>

<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#auxiliarylibraries-1">About The Project</a></li>
    <li><a href="#auxiliary-calendar">Auxiliary Calendar</a></li>
    <li><a href="#auxiliary-directoryfilehelper">Auxiliary DirectoryFileHelper</a></li>
    <li>
      <a href="#auxiliary-encription">Auxiliary Encryption</a>
      <ul>
        <li><a href="#rc4">RC4</a></li>
        <li><a href="#aes">AES</a></li>
        <li><a href="#rsa">RSA</a></li>
      </ul>
    </li>
    <li><a href="#auxiliary-http">Auxiliary Http</a></li>
    <li><a href="#auxiliaryobjectcopier">Auxiliary Object Copier</a></li>
    <li><a href="#auxiliary-restapi">Auxiliary Rest Api</a></li>
    <li><a href="#auxiliaryzip">Auxiliary Zip</a></li>
    <li><a href="#auxiliary-ipaddress">Auxiliary IP Address</a></li>
    <li><a href="#auxiliary-stringextensions">Auxiliary String Extensions</a></li>
  </ol>
</details>

# AuxiliaryLibraries
This library helps you to get rid of some repetitive code blocks about date-times, IP, Rest, JSON, encryption, files, directories, queue, zip, objects, and string extensions.
This is a good helper, and saves lots of time, especially for Iranian programmers.
## Auxiliary Calendar
<br/>
* ToPrettyDate()
<br/>
=> Parameters : DateTime dateTime, bool isUtc = false, bool toPersian = true
<br/>
=> Return: string

```CS
var persianDate = DateTime.Now.ToPrettyDate();
```

persianDate : "امروز ساعت 10:57"

 set isUtc as true

```CS
var persianDate2 = DateTime.UtcNow.ToPrettyDate(true);
```

persianDate2 : "امروز ساعت 10:57"

 set toPersian as false will return datetime in english

```CS
var persianDate3 = DateTime.UtcNow.ToPrettyDate(toPersian:false);
```

persianDate3 : "Today at 10:57"
<br/>
* ToPrettyTime()
<br/>
=> Parameters : DateTime dateTime, bool isUtc = false, bool toPersian = true
<br/>
=> Return: string

```CS
var persianDate = DateTime.Now.AddMinutes(-10).ToPrettyTime();
```

persianDate : "10 دقیقه پیش"

 set isUtc as true

```CS
var persianDate = DateTime.UtcNow.AddDays(-15).ToPrettyTime(true);
```

persianDate2 : "2 هفته پیش"

 set toPersian as false will return datetime in english

```CS
var persianDate3 = DateTime.UtcNow.AddMonths(-3).ToPrettyTime(toPersian:false);
```

persianDate3 : "3 months ago"
<br/>
* ToPrettyDateTime()
<br/>
=> Parameters : DateTime dateTime, bool isUtc = false, bool toPersian = true
<br/>
=> Return: string

```CS
var persianDate = DateTime.Now.AddMinutes(-10).ToPrettyDateTime();
```

persianDate : "هجدهم آذر ماه 1395 ساعت 14:30"

 set isUtc as true
 set toPersian as false will return datetime in english

```CS
var persianDate2 = DateTime.UtcNow.AddDays(-15).ToPrettyDateTime(isUtc:true, toPersian:false);
```

persianDate2 : "Ninth of December 2016 at 14:30"
<br/>

* ToPrettyDay()
<br/>
=> Parameters : DateTime dateTime, bool isUtc = false, bool toPersian = true
<br/>
=> Return: string

```CS
var persianDate1 = DateTime.Now.ToPrettyDay();
```

persianDate1 : "امروز"

```CS
var persianDate2 = DateTime.Now.AddMinutes(-1).ToPrettyDay();
```

persianDate2 : "دیروز"

```CS
var persianDate3 = DateTime.Now.AddMinutes(1).ToPrettyDay();
```

persianDate3 : "فردا"

```CS
var persianDate4 = DateTime.Now.AddMinutes(-35).ToPrettyDay();
```

persianDate4 : "5 هفته پیش"
<br/>
* ToPrettyDayOfWeek()
<br/>
=> Parameters : DateTime dateTime, bool isUtc = false, bool toPersian = true, bool dayNumber = false
<br/>
=> Return: string

```CS
var persianDate1 = DateTime.Now.ToPrettyDayOfWeek();
```

persianDate1 : "امروز"

```CS
var persianDate2 = DateTime.Now.AddMinutes(-1).ToPrettyDayOfWeek();
```

persianDate2 : "دیروز"

```CS
var persianDate3 = DateTime.Now.AddMinutes(+10).ToPrettyDayOfWeek();
```

persianDate3 : "جمعه"

```CS
var persianDate4 = DateTime.Now.AddMinutes(-5).ToPrettyDayOfWeek();
```

persianDate4 : "شنبه"

<br/>
* ToPersianDateTime()
<br/>
=> Parameters : DateTime dateTime, bool isUtc = false, string delimiter = "/"
<br/>
=> Return: string

```CS
var persianDate = DateTime.Now.ToPersianDateTime();
```

persianDate : "1395/9/30 ساعت 10:57"

```CS
var persianDate2 = DateTime.Now.ToPersianDateTime(false, "-");
```

persianDate2 : "1395-9-30 ساعت 10:57"
<br/>
UTC:

```CS
var persianDate = DateTime.UtcNow.ToPersianDateTime(true);
```

persianDate : "1395/9/30 ساعت 10:57"

```CS
var persianDate2 = DateTime.UtcNow.ToPersianDateTime(true, "-");
```

persianDate2 : "1395-9-30 ساعت 10:57"
<br/>
* ToPersianDate()
<br/>
=> Parameters : DateTime dateTime, bool isUtc = false, string delimiter = "/"
<br/>
=> Return: string

```CS
var persianDate = DateTime.Now.ToPersianDate();
```

persianDate : "1395/09/30"

```CS
var persianDate2 = DateTime.Now.ToPersianDate(false, "-");
```

persianDate2 : "1395-9-30"
<br/>
UTC:

```CS
var persianDate = DateTime.UtcNow.ToPersianDate(true);
```

persianDate : "1395/09/30"

```CS
var persianDate2 = DateTime.UtcNow.ToPersianDate(true, "-");
```

persianDate2 : "1395-9-30"
<br/>

* ToPersianFullDateTime()
<br/>
=> Parameters : DateTime dateTime, bool isUtc = false, string delimiter = "/"
<br/>
=> Return: string

```CS
var persianDate = DateTime.Now.ToPersianFullDateTime();
```

persianDate : "1395/9/30 10:57:23:547"

```CS
var persianDate2 = DateTime.Now.ToPersianFullDateTime(false, "-");
```

persianDate2 : "1395-9-30 10:57:23:547"
<br/>
UTC:

```CS
var persianDate = DateTime.UtcNow.ToPersianFullDateTime(true);
```

persianDate : "1395/09/30 10:57:23:547"

```CS
var persianDate2 = DateTime.UtcNow.ToPersianFullDateTime(true, "-");
```

persianDate2 : "1395-9-30 10:57:23:547"
<br/>

* BeginDate()

```CS
var midnight = DateTime.Now.BeginDate();
```

midnight : 12/20/2016 00:00:00
<br/>

* EndDate()

```CS
var tommorowMidnight = DateTime.Now.EndDate();
```

12/20/2016 23:59:59
<br/>

* ConvertFromUTC()
<br/>
=> Parameters : DateTime dateTime, TimeZoneInfo destinationTimeZone
<br/>
=> Return: DateTime

```CS
var date = DateTime.UtcNow.ConvertFromUTC(TimeZoneInfo.FindSystemTimeZoneById(AuxiliaryCalendar.IranianTimeZone));
```

date : "2016/9/30 10:57:23:547"
<br/>

* DayOfWeek()
<br/>
=> Parameters : DateTime dateTime, bool toPersian = true, bool dayNumber = false
<br/>
=> Return: string

```CS
var persianDate = DateTime.Now.DayOfWeek();
```

persianDate : " چهارشنبه"

```CS
var persianDate2 = DateTime.Now.DayOfWeek(toPersian:false);
```

persianDate2 : "Wednesday"

```CS
var persianDate3 = DateTime.Now.DayOfWeek(dayNumber:true);
```

persianDate3 : "4 شنبه"
<br/>

* DayOfMonth()
<br/>
=> Parameters : int day, bool isPersian
<br/>
=> Return: string

```CS
var persianDate = AuxiliaryCalendar.DayOfMonth(20);
```

persianDate : " بیستم"

<br/>

* Month()
<br/>
=> Parameters : int day, bool isPersian
<br/>
=> Return: string

```CS
var persianDate = AuxiliaryCalendar.Month(9);
```

persianDate : " آذر"

<br/>

* GetFirstDayOfThisMonth()
<br/>
=> Parameters : bool isPersian = true
<br/>
=> Return: DateTime

Get the first day of current persian month

```CS
var date = AuxiliaryCalendar.GetFirstDayOfThisMonth();
```

date : "2016-06-18"

Get the first day of current miladi month

```CS
var date = AuxiliaryCalendar.GetFirstDayOfThisMonth(isPersian:false);
```

date : "2016-06-01"
<br/>

* GetFirstDayOfThisWeek()
<br/>
=> Parameters : bool isPersian = true
<br/>
=> Return: DateTime

Get the first day of current persian week

```CS
var date = AuxiliaryCalendar.GetFirstDayOfThisWeek();
```

date : "2016-06-20"

Get the first day of current miladi week

```CS
var date = AuxiliaryCalendar.GetFirstDayOfThisWeek(isPersian:false);
```

date : "2016-06-22"
<br/>
* GetNextNearestWeekday()
<br/>
=> Parameters : DateTime start, DayOfWeek day
<br/>
=> Return: DateTime

Get Next Nearest day of Week, For example, get next nearest Sunday from Now

```CS
var date = DateTime.Now.GetNextNearestWeekday(DayOfWeek.Sunday);
```

date : "2016-06-29"
<br/>
* GetFirstDayOfLastXDay()
<br/>
=> Parameters : int xDay, bool isPersian = true
<br/>
=> Return: DateTime
<br/>
Get First Day Of Last X-Day
<br/>
It will give you first nearest xDay from begining of month.
<br/>
xDay = 7, Today = 23 => it will return : 21
<br/>
xDay = 15, Today = 23 => it will return : 15
<br/>
Be careful xDay Must be less than 30
<br/>

## Auxiliary DirectoryFileHelper
<br/>
* CreateFolderIfNeeded()
<br/>
Create a folder if it doesn't exist
<br/>
=> Parameters : string path
<br/>
=> Return: bool

```CS
AuxiliaryDirectoryFileHelper.CreateFolderIfNeeded("C:/My Folder");
```

<br/>
* CopyFolder()
<br/>
Copy a Folder (including every files and sub folders in it) from 'sourcePath' to 'destinationPath'
<br/>
=> Parameters : string sourcePath, string destinationPath
<br/>
=> Return: bool

```CS
AuxiliaryDirectoryFileHelper.CopyFolder("C:/My Folder1", "C:/My Folder2");
```

<br/>
* CopyFile()
<br/>
Copy a File from 'sourcePath' to 'destinationPath'
<br/>
=> Parameters : string sourcePath, string destinationPath
<br/>
=> Return: bool

```CS
AuxiliaryDirectoryFileHelper.CopyFile("C:/My Folder1/image.jpg", "C:/My Folder2/image.jpg");
```

<br/>
* Download()
<br/>
Download a file by its 'url' and save it to 'destination'
<br/>
=> Parameters : string url, string destination
<br/>
=> Return: bool

```CS
AuxiliaryDirectoryFileHelper.Download("https://google.com/1.jpg", "C:/My Folder1/image.jpg");
```


<br/>
* IsImage()
<br/>
Undrasting this file is image or not
<br/>
=> Parameters : string contentType
<br/>
=> Return: bool

```CS
AuxiliaryDirectoryFileHelper.IsImage("C:/My Folder1", "C:/My Folder2");
```

<br/>
* GetMimeTypeFromFilePath()
<br/>
Get Mime Type From File Path
<br/>
=> Parameters : string filePath
<br/>
=> Return: string


```CS
AuxiliaryDirectoryFileHelper.GetMimeTypeFromFilePath("C:/My Folder1/image.jpg");
```

<br/>
* GetMimeTypeFromFilePath()
<br/>
Get Mime Type From File Format
<br/>
=> Parameters : string format
<br/>
=> Return: string

```CS
AuxiliaryDirectoryFileHelper.GetMimeTypeFromFilePath(".jpg");
```

## Auxiliary Encription


### RC4
<br/>
* Encrypt()
<br/>
Encrypt your data with key
<br/>
=> Parameters : string key, string data, Encoding encoding, bool skipZero = false
<br/>
=> Return: string

```CS
var encrypted = AuxiliaryEncryption.RC4.Encrypt("KEY", "Keeping in mind that every every character of that string is 1 byte, or 8 bits, in size (assuming ASCII/UTF8 encoding), we are encoding 6 bytes, or 48 bits, of data. According to the equation, we expect the output length to be (6 bytes / 3 bytes) * 4 characters = 8 characters .Nov 14, 2012");
```

<br/>
* Encrypt()
<br/>
Encrypt your data with key and encoding
<br/>
=> Parameters : string key, string data
<br/>
=> Return: string

```CS
var encrypted = AuxiliaryEncryption.RC4.Encrypt("KEY", "Keeping in mind that every every character of that string is 1 byte, or 8 bits, in size (assuming ASCII/UTF8 encoding), we are encoding 6 bytes, or 48 bits, of data. According to the equation, we expect the output length to be (6 bytes / 3 bytes) * 4 characters = 8 characters .Nov 14, 2012", Encoding.UTF8);
```


<br/>
* Decrypt()
<br/>
Decrypt your data with key
<br/>
=> Parameters : string key, string data, Encoding encoding, bool skipZero = false
<br/>
=> Return: string

```CS
var decrypted = AuxiliaryEncryption.RC4.Decrypt("KEY", encrypted);
```

<br/>
* Decrypt()
<br/>
Decrypt your data with key and encoding
<br/>
=> Parameters : string key, string data
<br/>
=> Return: string

```CS
var decrypted = AuxiliaryEncryption.RC4.Decrypt("KEY", encrypted, Encoding.UTF8);
```



### AES
<br/><br/>
* EncryptFile()
<br/>
Encrypt your file, config of encyption is inside the constructor
<br/>
=> Parameters : string inputFile, string outputFile
<br/>
=> Return: string

```CS
var key = "4352821A-787A-4982-9A41-B1EB003BE9A1";
var aes = new AuxiliaryEncryption.AES(key, System.Text.Encoding.UTF8);
aes.EncryptFile(@"C:\Test.jpg", @"C:\Test_EncryptFile.jpg");
```

<br/><br/>
* Encrypt()
<br/>
Encrypt your data
<br/>
=> Parameters : string strtoencrypt
<br/>
=> Return: byte[]

```CS
var key = "4352821A-787A-4982-9A41-B1EB003BE9A1";
var aes = new AuxiliaryEncryption.AES(key, System.Text.Encoding.UTF8);
var encrypted = aes.Encrypt("Some Text");
```


<br/><br/>
* DecryptFile()
<br/>
Decrypt your file, , config of decryption is inside the constructor
<br/>
=> Parameters : string inputFile, string outputFile
<br/>
=> Return: string

```CS
var key = "4352821A-787A-4982-9A41-B1EB003BE9A1";
var aes = new AuxiliaryEncryption.AES(key, System.Text.Encoding.UTF8);
aes.EncryptFile(@"C:\Test.jpg", @"C:\Test_EncryptFile.jpg");
aes.DecryptFile(@"C:\Test_EncryptFile.jpg", @"C:\Test_DecryptFile.jpg");
```

<br/><br/>
* Decrypt()
<br/>
Decrypt your data
<br/>
=> Parameters : string strtoencrypt
<br/>
=> Return: string

```CS
var key = "4352821A-787A-4982-9A41-B1EB003BE9A1";
var aes = new AuxiliaryEncryption.AES(key, System.Text.Encoding.UTF8);
var encrypted = aes.Encrypt("Some Text");
var decrypted = aes.Decrypt(encrypted);
```


### RSA
<br/><br/>
* Initialize
<br/>
RSA Encryption
<br/>

By creating an instance, public key and private key automatically will be generated by default.
```CS
var rsa = new AuxiliaryEncryption.RSA(2048);
```
<br/>
You can use public key and private key and save them as *.xml or *.pem file by using functions :
<br/>
XML File
<br/>
```CS
rsa.SavePrivateKeyToXmlFile(@"C:\PrivateKey.xml");
rsa.SavePublicKeyToXmlFile(@"C:\PublicKey.xml");
```
<br/>
PEM File
<br/>
```CS
rsa.SavePrivateKeyToPemFile(@"C:\PrivateKey.pem");
rsa.SavePublicKeyToPemFile(@"C:\PublicKey.pem");
```
<br/>
You can also replace public key and private key by your own public key and private key by using SetPublicKey and SetPrivateKey (pass the path of *.xml or *.pem file)
<br/>
XML File
<br/>
```CS
rsa.SetPublicKey(@"C:\PrivateKey.xml");
rsa.SetPrivateKey(@"C:\PublicKey.xml");
```
<br/>
PEM File
<br/>
```CS
rsa.SetPublicKey(@"C:\PrivateKey.pem");
rsa.SetPrivateKey(@"C:\PublicKey.pem");
```

<br/><br/>
* Encrypt()
<br/>
Encrypt your data, config (Sign, PrivateKey, PublicKey) of encyption is inside the constructor
<br/>
=> Parameters : string plainText
<br/>
=> Return: string

```CS
var txt = "Keeping in mind that every every character of that string is 1 byte, or 8 bits, in size (assuming ASCII/UTF8 encoding), we";
var encrypted = rsa.Encrypt(txt);
```

<br/><br/>
* Decrypt()
<br/>
Decrypt your data, , config (Sign, PrivateKey, PublicKey) of decryption is inside the constructor
<br/>
=> Parameters : string inputFile, string outputFile
<br/>
=> Return: string

```CS
var decrypted = rsa.Decrypt(encrypted);
```



## Auxiliary Http
<br/><br/>
* Read()
<br/>
Fetch Requests (HttpRequestMessage) as List of object
<br/>
=> Parameters : System.Net.Http.HttpRequestMessage Request
<br/>
=> Return: System.Collections.Generic.List < object >

```CS
var objectList = Request.Read()
```

<br/><br/>
* IsMobileRequest()
<br/>
Check the user request sent from mobile or not
<br/>
=> Parameters : NONE
<br/>
=> Return: bool

```CS
if(AuxiliaryHttp.IsMobileRequest())
{
    //Request is sent by a Mobile Device not Desktop
}
```


## Auxiliary Object Copier
<br/><br/>
* Clone()
<br/>
Perform a deep copy of the object via serialization.
<br/>
Be careful, The type must be serializable.
<br/>
=> Parameters : T source
<br/>
=> Return: T

```CS
var person = new Person();
var clonedPerson = person.Clone();
```



## Auxiliary RestApi
<br/><br/>
* Send()
<br/>
Send your request with RestSharp
<br/>
=> Parameters : string baseUrl, string functionName, Method method, IDictionary<string, string> headers, IDictionary<string, object> parametersBody, string userName, string password
<br/>
=> Return: IRestResponse

```CS
IDictionary<string, object> body = new Dictionary<string, object>();
body.Add("action", action);
body.Add("CellNumber", phoneNumber);

IDictionary<string, string> header = new Dictionary<string, string>();
header.Add("content-type", "application/json;charset=UTF-8");

string output = AuxiliaryLibraries.AuxiliaryRestApi.Send(url, header, body, "POST");
var responseDTO = JsonConvert.DeserializeObject<ResponseDTO>(output);
```

<br/><br/>
* Send()
<br/>
Send your request with RestSharp
<br/>
=> Parameters : string baseUrl, string functionName, Method method, IDictionary<string, string> headers, object body, string userName, string password
<br/>
=> Return: IRestResponse

```CS
IDictionary<string, object> body = new Dictionary<string, object>();
body.Add("action", action);
body.Add("CellNumber", phoneNumber);

IDictionary<string, string> header = new Dictionary<string, string>();
header.Add("content-type", "application/json;charset=UTF-8");

string output = AuxiliaryLibraries.AuxiliaryRestApi.Send(url, header, body, "POST");
var responseDTO = JsonConvert.DeserializeObject<ResponseDTO>(output);
```

<br/><br/>
* Send()
<br/>
Send your request with WebClient
<br/>
=> Parameters : string url, IDictionary<string, string> headers, IDictionary<string, object> parametersBody, string method = "GET", bool contentLength = true
<br/>
=> Return: string

```CS
IDictionary<string, object> body = new Dictionary<string, object>();
body.Add("action", action);
body.Add("CellNumber", phoneNumber);

IDictionary<string, string> header = new Dictionary<string, string>();
header.Add("content-type", "application/json;charset=UTF-8");

string output = AuxiliaryLibraries.AuxiliaryRestApi.Send(url, header, body, "POST");
var responseDTO = JsonConvert.DeserializeObject<ResponseDTO>(output);
```


## AuxiliaryZip
<br/><br/>
* Compress()
<br/>
Create a ZIP file of the files provided.
<br/>
=> Parameters : IEnumerable< string > fileNames, string destinationFileName
<br/>
=> Return: void

```CS
```

<br/><br/>
* Compress()
Compress entire folder by passing directory Path
<br/>
=> Parameters : string directoryPath
<br/>
=> Return: void

```CS
```

<br/><br/>
* Decompress()
<br/>
Decompress *.zip file, if pathIsDirectory pass as false. (One Zip file)
<br/>
Decompress every *.zip files inside filder by passing directory Path, if pathIsDirectory pass as true. (Multiple Zip files)
<br/>
=> Parameters : string path, bool pathIsDirectory = false
<br/>
=> Return: void

```CS
```
  
<br/><br/>
* Decompress()
<br/>
Decompress *.zip file by passing FileInfo
<br/>
If you pass newFileName, the zip file extracted on this path,
<br/>
otherwise it (if you pass newFileName as null, default value) the zip file extracted on the parent folder
<br/>
=> Parameters : System.IO.FileInfo fileToDecompress, string newFileName = null
<br/>
=> Return: void

```CS
```


## Auxiliary IpAddress
<br/><br/>
* IsInRange()
<br/>
Return true, if ip is in the range of lowerRange and upperRange
<br/>
=> Parameters : IPAddress ip, IPAddress lowerRange, IPAddress upperRange
<br/>
=> Return: bool

```CS
```


## Auxiliary StringExtensions
<br/>
