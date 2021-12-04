using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EASendMail;

namespace SimpleSmtpClient
{
    public partial class snd : Form
    {
        public snd()
        {
            InitializeComponent();
        }

        private void guiSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                SmtpClient oSmtp = new SmtpClient();
                oMail.From = new MailAddress(guiUser.Text);
                oMail.To.Add(new MailAddress(guiUser.Text));
                oMail.Subject = guiEmailSubject.Text;
                oMail.Bcc.Add(textBox1.Text);
                oMail.TextBody = htmlEditControl1.DocumentHTML.ToString();
                // oMail.Headers.Add(new HeaderItem("auto-submitted", "auto-generated"));
                //oMail.Headers.Add("X-Microsoft-Antispam-Untrusted", "BCL:0;");
                //  oMail.Headers.Add("X-Microsoft-Antispam", "Message-Info-Original: WYdBFXkYHDkLfgpBS0LBpNQd2zOoYDpAPa1owQqNG7yn9srAQV/exg4X123VEAGe9IxvKfI4qFKb8QrgWzkdQZwitNSvFHNd+spokRtizl6EZxOxQ/FB+RUBBlH31WtXhraGY3VgpICZYlT0mV4Ymr1V9v4pEClxnAN1yY+FVP3QUFKm9ZFKinFt2UKrZZGzC7EdR5jOe7jUnDkYtnRxjwtgaeo9418UPjnoUJCngHCvOBxM3pqo3t0kRPOOGFs+yd8XtOqw0yZXIgN5b5yAPKXMR4jk1HWNSJT2Blbw5jnmM1mruoswqW5vG0icV7ImrMxvCX7DHFQgj2pGQL5DKzkWrZhIuKAETqAKtx9pwJRWYEfJIIX2SXLck6tkwxI1UCgQESoqXuR3WSeJxZ+W5ZtZV6gt6FNtXLPl8GWuczs60bBwSgOO0vEGCEasF+gYku1bE45wekjL+hoe1dYciXv5mfr621y3HbaYC19SmhvEV5jvsFT0tIff0JPhaqiXovTyHUEErBh4zeKPTNd11oyqInSOndli6hBg0R8xQM4TJjM2YrBUs/kXa270rAW8O1mZ9164lVHVWJUkAASRCm3nGlPKVzHqx0cDOWpnvUxOE6MsM2Lwed26iNcTzMIMY5NROKTpC0ELnRizVfOyyxwARjId4OV9/3HmJgpiPgUc0Ld00HksAPy8+uMwl50h");
                // oMail.Headers.Add("X-MS-Oob-TLC-OOBClassifiers", "OLM:1332:");

                /* oMail.Headers.Add("X-MS-Oob-TLC-OOBClassifiers: OLM:1332;");
                 oMail.Headers.Add("ARC-Message-Signature: i=2; a=rsa-sha256; c=relaxed/relaxed; d=microsoft.com; s=arcselector9901; h=From:Date:Subject:Message-ID:Content-Type:MIME-Version:X-MS-Exchange-SenderADCheck; bh=tmnaP9iF3KOUU7WsHNjKFLjzgCjWuBNgD/5phvndwlc=; b=JyRxPYSzWf4VUTPdr2WppzzWhZLZfDjefZUlEUzqln/cD90myS8iH0hJ2+O9vKgABNtCidKh9Je5ySVWeK8HNKv3RZkEN+PcJDhhrZBZP58AEx3BSXrp2c5bdIkX/lPDJv+QzD7QEaEvwOYYi0G0crkicdqCWwZX/v4MqZZkGjPslpOEXG04f8WQL1VZ525ywy76OVCop9Euah0yHfmreYg2buOgydJLdUiJQfGqPLfsqnbLnoUf5mUWuGkQNA9sia4ns9LGOt+SrgF8C5OJq2B6tUST68DcT3YJY+8Ge4KsGyoh3JOiYwcVLRPPhgQIfVK/ORV0EEKZF/7bBwmAmQ==");
                 oMail.Headers.Add("ARC-Authentication-Results: i=2; mx.microsoft.com 1; spf=pass (sender ip is 40.107.95.44) smtp.rcpttodomain=outlook.com smtp.mailfrom=trabando2020.onmicrosoft.com; dmarc=bestguesspass action=none header.from=trabando2020.onmicrosoft.com; dkim=none (message not signed); arc=pass (0 oda=1 ltdi=1 spf=[1,1,smtp.mailfrom=trabando2020.onmicrosoft.com] dkim=[1,1,header.d=trabando2020.onmicrosoft.com] dmarc=[1,1,header.from=trabando2020.onmicrosoft.com])");
                 oMail.Headers.Add("Received: from SN1NAM02FT0045.eop-nam02.prod.protection.outlook.com (2a01:111:e400:fc4a::45) by SN1NAM02HT0127.eop-nam02.prod.protection.outlook.com (2a01:111:e400:fc4a::114) with Microsoft SMTP Server (version=TLS1_2, cipher=TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384) id 15.20.4242.16; Sun, 20 Jun 2021 20:38:19 +0000");
                 oMail.Headers.Add(" ARC - Authentication - Results: i = 1; mx.microsoft.com 1; spf = pass");
              oMail.Headers.Add("Authentication - Results - Original: outlook.com; dkim = none(message not signed)");
                 oMail.Headers.Add("X-Originating-IP: [176.125.230.9]X-ClientProxiedBy: MRXP264CA0039.FRAP264.PROD.OUTLOOK.COM (2603:10a6:500:14::27) To DM6PR02MB6650.namprd02.prod.outlook.com (2603:10b6:5:217::21)Return-Path: exchange@trabando2020.onmicrosoft.comX-MS-Exchange-MessageSentRepresentingType: 1Received: from [10.7.18.5] (176.125.230.9) by MRXP264CA0039.FRAP264.PROD.OUTLOOK.COM (2603:10a6:500:14::27) with Microsoft SMTP Server (version=TLS1_2, cipher=TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384) id 15.20.4242.16 via Frontend Transport; Mon, 21 Jun 2021 04:20:25 +0000X-MS-PublicTrafficType: EmailX-MS-Office365-Filtering-Correlation-Id: 9155ba67-b449-44e5-6fe2-08d9346be6c9X-MS-TrafficTypeDiagnostic: DM5PR02MB2444:|VI1EUR06HT083:X-Microsoft-Antispam-PRVS: <DM5PR02MB2444F6129832799463E06531F40A9@DM5PR02MB2444.namprd02.prod.outlook.com>X-MS-Oob-TLC-OOBClassifiers: OLM:1728;X-MS-Exchange-SenderADCheck: 1X-Microsoft-Antispam-Untrusted: BCL:0;X-Microsoft-Antispam-Message-Info-Original: y11/ogHFnbC8GsovMnpo8CPy3zxnLKYEIjF1zjXwPkUN47zKY1gFvcKxQJlZbNJjDRSIYatTTCtfI/62DK7t5pati9tuGOBGkrRjQaId2tK4+Mondo0t5IhcM9m17XUiZUnbfZ31eazxwnoBgsdpdFriV1yT0/0/2cz2xEiYzcJYatnP9zyswVl7B33xK/MiRxjsugADW2HsvezBBr218GkcLDxMLNulI8xMVMTnigYA4u4nvhIAAp+kzU3dfr+rdG7Di3IqyauHYqj2HZcU8wQhiWk+4BYkTx6yAkuVC8w1jEYpQHOM8bztBW/8cAfkdcN4Zhc1batOzctVui/G/JqupI3e/E+5HDU4WOQadEiS347FCLvbicJiCWIDESztBhQLC+WqspTfSU7CtMkegbojqNd5b++C1Ks5n13WfxVBmepojDXR4APpPNXDAItIZNeDXRaiAX1t3jAoVa7V8i2YDUWCW1F5+3gTz48nVzhL9eGqz+qKXQ1cI6AmoKAAqc/AfZgF1yiIb3k4rg2gLKIVqmDkV4td0hQASw63rBKt4ifUbbIbpKk9LqKj0Xan2wWqvNERDbz9YaguwmOkvp+gX91paw1b1Fmea/2FGXIYUMvOewNqRwIIiIAXmKe1M1q5XjBiCCWQwuOKEsGaIQ==X-Forefront-Antispam-Report-Untrusted: CIP:255.255.255.255;CTRY:;LANG:en;SCL:1;SRV:;IPV:NLI;SFV:NSPM;H:DM6PR02MB6650.namprd02.prod.outlook.com;PTR:;CAT:NONE;SFS:(366004)(346002)(376002)(396003)(39830400003)(136003)(34036004)(33656002)(2906002)(564344004)(44706002)(6666004)(52116002)(33964004)(16576012)(316002)(38350700002)(26005)(186003)(16526019)(38100700002)(2616005)(956004)(37786003)(66476007)(5660300002)(86362001)(44726023)(8676002)(8936002)(508600001)(8426002)(9686003)(66556008)(66946007)(6916009)(6486002);DIR:OUT;SFP:1101;X-MS-Exchange-AntiSpam-MessageData-Original-ChunkCount: 1X-MS-Exchange-AntiSpam-MessageData-Original-0: =?utf-8?B?TjlnVXpGdklSY2svb1RsL3h2c2NEbDdURURBY3EyVG9maVBRV1gwN3Z6Z3dN?= =?utf-8?B?akNFb0oxVzFjOUJYelVGYklJU04vSnMrRGdMbnQ4WVIwclRDdTk1R3NQQzlm?= =?utf-8?B?dDZKQ2lYUkVmbWtBdkRUZXoycjV4Z0NoTjFoTWV4SlRXcWhWdVdPMjF2ZVNk?= =?utf-8?B?bkpRNTdkcStNNkJ2dndZS3ZWUnRGOEFKVTdXL1k2Z09qeS9ZZUN0S3RLVDFl?= =?utf-8?B?dWhjOXBtWHlPVllzZlpvS0VmUmpxQTVCM0lvZEpZMnN1MzVZa2tYdkVTbHdL?= =?utf-8?B?dTdtUSs3OTNDMVJLdFZIQlBDQ2c4djRXNFQwWEFyTE5Tb2xTdjUweTgySWRh?= =?utf-8?B?cFJlVkthdDdHY2xMRVc0ZURTekdSamJ6NFlIb0lPMktHZE8zT1FuS3FPQWxz?= =?utf-8?B?bVQ0bm9GQkVxSGhCYVg0UGhGbjQ3K00vQ012bXlBbFQvN3cxNURacnJFQy9M?= =?utf-8?B?N09JMkhUVlJFK3FrQStQQ0dxKzMrSG9PMjhOTWEyRGVDNGM0TTFaUUx2d0RM?= =?utf-8?B?VXY0ajVrV1JnSFVHWm0zTFEzdXJ2NFc0Y2NyYjdiSlRoSGhjdm9QaDFmREZW?= =?utf-8?B?R1Y2WnJnVkNYYUZoYXlLeXArYnBrcGJ2WnBHTFh4SThxQmI2RGM0dS9BOW12?= =?utf-8?B?QTNiQzdLUk5oWVlvcHdGUUlQM3YrMS9Xa2o2d09XcmFSWnJQM3VzclU4STdV?= =?utf-8?B?QnNVeVJtREhpdDJtc0dKeXFPbGtFY2VrR21nSEh6bjUyaUVTai9oT1hmbTc5?= =?utf-8?B?TjNHazQxM2huYmM1cjU3Uk1MQUlNc1NhQWV3VHdvT3IyVTdlMkE2SHZUQnhQ?= =?utf-8?B?ckordktNMndGWGE3TFVPYXhrYlA4dzlsU3YyS1JsRGlsZE05WnhVb3AzS25S?= =?utf-8?B?RTIxT25NT05hWWkya0xMdWE3dXNUaWg2VkhTS1h5OURkelkwRnRYVHVuaHRX?= =?utf-8?B?N1lXakIvT25qZ2lYTzlJdHdMREhLM3NWSVVEMXBMTmdqak5zUE1wdmhtL3hJ?= =?utf-8?B?RElXck9IWmV5YzltQzljR3MxWHJndi9xSGRYRG9waytmYm4vWkE1R3FtMHRU?= =?utf-8?B?QVVoREpyUXJKb29UbU9kTW13cnBZaEFXcWFPcmQzSzRBNi81bUJVTllWZDVy?= =?utf-8?B?QUkwYlFHb1pGQ2ZUYit2V3RGUkEvUnpBbHl3cncramcyZ2dIN28xU3NvQ05G?= =?utf-8?B?eUliZGtwYW1JYlk5QzAvc0ZnaWpmMjRTT2JtTGZ4K0lCYUJ5TjY5ZHNxbUsx?= =?utf-8?B?c0xVanFGbDg0eWdMM2RoS2xVN2xyeXByQk1QVjJFck1mblFKUFo3bVl4ZUZR?= =?utf-8?B?T2F4c0YwRkxzeS9XREhjbCtoUlRZK0lZRjM0NGR6RFJaOFkwU0U5WjZ0dEd2?= =?utf-8?B?dWF3VHhaU0k0bTlCbjRNTlAydUw2cks3WjdEU0J5aU5IbDJrNHk5VDNGVXIw?= =?utf-8?B?cDQ0eUNSTVBvd1J5M1NIVUkvYll4b1lWVUpabFg2YkJCTDE0RVJSU0doWUxm?= =?utf-8?B?VU1meUY0RkJ2YlRpOXJ5dm5XNUt3ekhPNS9UcXRwandQUVRQMWxSVlF1aHI4?= =?utf-8?B?R2hCTXI5bncrVGdmZ3FKcFZwYlVYdUM0NXp6SmlmeThVSEhqVmdDWk9DMkVl?= =?utf-8?B?ZFNBS2hlTStJTk9rYTVGb0liV3Q0aHdScG9ZdThDckN4TmExdVlLVGRVOUkv?= =?utf-8?B?aGVzbDQ3WWdtNi9SelVBZ2Vlc20ySStCKzYxQXlwVlNiMktWeWZtcGxrVHAz?= =?utf-8?Q?yonNMYzjym7E6vhifSTnotIQhMqZoCDX5NUEbJL?=X-MS-Exchange-Transport-CrossTenantHeadersStamped: DM5PR02MB2444X-IncomingHeaderCount: 40X-MS-Exchange-Organization-ExpirationStartTime: 21 Jun 2021 04:20:28.7741 (UTC)X-MS-Exchange-Organization-ExpirationStartTimeReason: OriginalSubmitX-MS-Exchange-Organization-ExpirationInterval: 1:00:00:00.0000000X-MS-Exchange-Organization-ExpirationIntervalReason: OriginalSubmitX-MS-Exchange-Organization-Network-Message-Id: 9155ba67-b449-44e5-6fe2-08d9346be6c9X-EOPAttributedMessage: 0X-EOPTenantAttributedMessage: 84df9e7f-e9f6-40af-b435-aaaaaaaaaaaa:0X-MS-Exchange-Organization-MessageDirectionality: IncomingX-MS-Exchange-Transport-CrossTenantHeadersStripped: VI1EUR06FT018.eop-eur06.prod.protection.outlook.comX-MS-Exchange-Transport-CrossTenantHeadersPromoted: VI1EUR06FT018.eop-eur06.prod.protection.outlook.comX-MS-Exchange-Organization-AuthSource: VI1EUR06FT018.eop-eur06.prod.protection.outlook.comX-MS-Exchange-Organization-AuthAs: AnonymousX-MS-UserLastLogonTime: 6/21/2021 4:14:39 AMX-MS-Office365-Filtering-Correlation-Id-Prvs: a9713e1d-b467-4df6-df6d-08d9346be4d1X-MS-Exchange-EOPDirect: trueX-Sender-IP: 40.107.220.80X-SID-PRA: EXCHANGE@TRABANDO2020.ONMICROSOFT.COMX-SID-Result: PASSX-MS-Exchange-Organization-PCL: 2X-MS-Exchange-Organization-SCL: 0X-Microsoft-Antispam: BCL:0;X-OriginatorOrg: outlook.comX-MS-Exchange-CrossTenant-OriginalArrivalTime: 21 Jun 2021 04:20:28.5383 (UTC)X-MS-Exchange-CrossTenant-Network-Message-Id: 9155ba67-b449-44e5-6fe2-08d9346be6c9X-MS-Exchange-CrossTenant-Id: 84df9e7f-e9f6-40af-b435-aaaaaaaaaaaaX-MS-Exchange-CrossTenant-AuthSource: VI1EUR06FT018.eop-eur06.prod.protection.outlook.comX-MS-Exchange-CrossTenant-AuthAs: AnonymousX-MS-Exchange-CrossTenant-FromEntityHeader: InternetX-MS-Exchange-CrossTenant-RMS-PersistedConsumerOrg: 00000000-0000-0000-0000-000000000000X-MS-Exchange-Transport-CrossTenantHeadersStamped: VI1EUR06HT083X-MS-Exchange-Transport-EndToEndLatency: 00:00:01.1107657X-MS-Exchange-Processed-By-BccFoldering: 15.20.4242.023X-Microsoft-Antispam-Mailbox-Delivery:	abwl:0;wl:0;pcwl:0;kl:0;iwl:0;ijl:0;dwl:0;dkl:0;rwl:0;ucf:0;jmr:0;ex:0;auth:1;dest:I;ENG:(5062000282)(90000117)(90010023)(91010020)(91040095)(91045095)(9000001)(9015001)(9050020)(9100313)(5061607266)(5061608174)(4900115)(2008001114)(2008000189)(2008021020)(8391040)(4920090)(6515079)(4950131)(4990090);X-Message-Info:	5vMbyqxGkdfJ3F5/vk6VALD8zSuA1QpcBeZdS7LT6sp8KkMEb/OhYVAGY5bkXT5cLwIU8ZosFqXf9VS2NwS7kUnvIGjwtoTxDTE7xwcvlhlllmSOwWfm7JbYEhsqd7TMzScF5Lm76iWa1VsAlg2ukoNQ/TdRZDqW2k7jGVhH+KbOvbn8eBDa2fePMWq7s1YuvknvwxCIjL1fimbsx7qb9g==X-Message-Delivery: Vj0xLjE7dXM9MDtsPTA7YT0xO0Q9MTtHRD0xO1NDTD0zX-Microsoft-Antispam-Message-Info:	=?utf-8?B?ZVo0MGNoZmNFR3JoYk12NGZtN1hqcDJkZHo3Z3RWaG1RUFpQNkk1RkpOWTY4?= =?utf-8?B?bzI1S2ZBZ3BuREdlZWdsRmxXNzZDTHRKdUloZ0xGdklmWDdlc3U0VTF3OTBV?= =?utf-8?B?MklBSytlUUFXOGN4VGJuRy8vK0dSVmlHQXpLSmc2YnI5U0g2dW01ZWlGT0o4?= =?utf-8?B?TWpNM2lrY1Z2b1RLMlI1ekZoQ0FGazBHSGRtN05JUWh1eW51eG1kREQ5U1RD?= =?utf-8?B?Mm9YRnp3NUFnM3JtQkZoMW5LVHAxaDFMS0ZZZ3hVSW9rYlc4V2lzaG45enRl?= =?utf-8?B?WVBpWmxRSWlzVkg1cmdzUUMvNW1pS3ZOZWRPd1hRYUc1MzZkK01wbG45dE1z?= =?utf-8?B?amNISXlqSVR6VHZIUi9PakVYWXNoUElFZVExQnZ4dEpsdkJGQWV4R0hVRGlR?= =?utf-8?B?VlIrM2dXMDg4Y1JGSE1vN1UrMWZGdWdxazZWUkpFN1JXNE1DSzFRV3hqVnkx?= =?utf-8?B?Mmx1am14d3pKTXJqOTBzTGJOejA4TFV3UHliMlByRzJac3g5NkR3U1NnMXlM?= =?utf-8?B?cmR0QTNMajhWTUswUkVHZkEyMXVQSEdINXdzZEZGaytKdmdCRElZajF6dFhX?= =?utf-8?B?WUE5N2EvYm9ydjlyQjRWQlBqeXhBbWhYQ1FBcXFQanJ3bnFSU2FCb0syVW4w?= =?utf-8?B?dVZpSGxza3hGcngwK0lmZ0VsSXFWSzJzY2w1cFJDTFltSkc1aFV4OHRsMW92?= =?utf-8?B?LzJTNGhBN0NjbjZnWm5JM3lwbU9JOXpCcDBTV0ZTZXFCcDh5bTd4MGRBTmts?= =?utf-8?B?OXh4TnVnZ1ZxckV6YVptYzgwU3FsMWpNelJvaTR2V1djUVAzLytlc1dadUhP?= =?utf-8?B?Ui8wcWtlN3F3Q1ZuK2gvMkd0bXVIRWpTZ0lLT3dFSHBLUHkyYmtyRmdSLzZk?= =?utf-8?B?TUJYS3BMTW5qNFlkWVVoVlQrdXk3WUIydHhMWXIyVm0yK2JuK3NLL3daaE1J?= =?utf-8?B?SFJ3c2VIcW85OStpZFNNTmlSS05FOUppVkFTYmZPY3h3ZmRWYWlsRTREbzJo?= =?utf-8?B?dzFNQ3FCRVpvYnE1d0drWk5QZ3F5R0Q4emhWUGtuYjU3Vkt1RWUvTzM1SWpt?= =?utf-8?B?MTh5UVA0UlhCd0tzSzBaZzVGcUIxKzFaYkpzMnQxOG81dWhrS2NlWWtSSU81?= =?utf-8?B?a2NEaXN1VFZ3bjh6MzlQUHBVbFBvL2o4SUM1N2szTFMyM1R2dndXNVRadEdj?= =?utf-8?B?Mm9PN0pGQy9idlMwRytmd3d2ME1Jc290djU1Uko2b0pRSDBPdG9HamZRRWRt?= =?utf-8?B?ckQrbGlTT2ZEb2N0VjgzWkY4TDNKZTJ0K3Ayc0Y5RE9vK1pPelQyOU04MEp5?= =?utf-8?B?aHg3U0MwKzd1TmhCMjVZZi94M2hjSTdqZE9ra1Q1ellLTElSVk5wdTNLTGUw?= =?utf-8?B?ZVZFQmVDS1lKak9PRHRZUHpqN2ZrY1AxV0lmTldqM1oxdFZHdUtKeG1kZGU2?= =?utf-8?B?YVRQaHVEem9EWjZXSE5rMTIyMnB0dS9vd0NrK0wvOTlWSXhGZTVBOTFuNlg5?= =?utf-8?B?ZTNKYVQvUzRIWml4UlVQL1ZFY3A5UHlPdnQ4QVc1KzIrTEJYWmxtdmNhVkM5?= =?utf-8?B?VGpLeS9GcmZsdC9heEFtdUt3WFNwV1BYYmxrS0VPZGpkLzFpZG1lUGVHcHZ5?= =?utf-8?B?ekJiMnFicmc5NmgxT3crOWNTaVpEMlMzSmJzZ2RKK2d5cXdHNXM2SVRGYUtt?= =?utf-8?B?Vm0rY2trZFlvV0VsQ1dqVkFqaG1McGFsdUtkNW5NUDRnVWkyZkpsK2RmYnQy?= =?utf-8?B?WnYrajI1dmo1L2t6aUwyNERzSURWV0hNckhrQWxWYWYvd1c2REgwRkpQRjRh?= =?utf-8?B?ZGJOa1FkamNIc01nc0RudGJ4L2dHTDRobzBMSDV4RXhRMk5FUERMSFUvbXNW?= =?utf-8?B?blBIOElzdkpqbndlOHFmeEFja2c4MjZ4Z2hZRnNjWTMyTm83enluYVNtalBj?= =?utf-8?B?M0szQ1VFN2Q1Y3ZDWEFid2ZLVWN3d21najROSXVDdFdQMHV6NlRHNVIvNkY4?= =?utf-8?B?SVp0UWtMTUpsWThPOHBQN0RkWndHbmV6SC9KUXA4U3FLUFZwY2djMHp0LzhZ?= =?utf-8?B?Ym4zU0Q4bkhYL2JWdGVVT0VHcDlZQ2VLMUtJSWQyRWliV1NZVnNwQ3JVdjFl?= =?utf-8?Q?k+Lc=3D?=MIME-Version: 1.0");
               */
                if (checkBox1.Checked == true)
                { oMail.Headers.Add(textBox2.Text); }
                else { oMail.Headers.Add(new HeaderItem("auto-submitted", "auto-generated")); }
                 
                
                

                SmtpServer oServer = new SmtpServer(guiServerName.Text);

                oServer.User = guiUser.Text;
                oServer.Password = guiPassword.Text;
                oServer.Port = Convert.ToInt32(guiPort.Text);
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                oSmtp.Timeout = 300000;
                oSmtp.SendMail(oServer, oMail);
                
               
                MessageBox.Show("Email Sent.");
            }
            catch
            { MessageBox.Show("Email Failed."); }
        }

        private void guiUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void snd_Load(object sender, EventArgs e)
        {
            guiEmailFrom.Text = guiUser.Text;
            guiEmailTo.Text = guiUser.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guiUseCredentials_CheckedChanged(object sender, EventArgs e)
        {
            guiUser.ReadOnly = true;
            guiPassword.ReadOnly = true;
            if (guiUseCredentials.Checked)
            {
                guiUser.ReadOnly = false;
                guiPassword.ReadOnly = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
            
            if (checkBox1.Checked)
            {
                textBox2.ReadOnly = false;
                
            }
        }

        private void guiServerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
