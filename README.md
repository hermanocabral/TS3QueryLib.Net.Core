# TS3QueryLib.Net.Core 
[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=QYZZU6CH727YA) [![Build Status](https://travis-ci.org/Scordo/TS3QueryLib.Net.Core.svg?branch=master)](https://travis-ci.org/Scordo/TS3QueryLib.Net.Core) [![NuGet Status](https://img.shields.io/nuget/vpre/TS3QueryLib.Net.Core.svg)](https://www.nuget.org/packages/TS3QueryLib.Net.Core)<BR/><BR/>
This library allows you to query TeamSpeak 3 servers using the query port.<BR/>
All queries are implemented type-safe in .Net Core. 

**This library is work in progress and not final yet!** <BR/>

**Query Types** (&#x2714; implemented - &#x2716; not implemented yet):
* &#x2714; Server
* &#x2716; Client

**File tranfer functionality** (&#x2714; implemented - &#x2716; not implemented yet):
* &#x2714; Download
* &#x2714; Upload

**List of Notifications** (&#x2714; implemented - &#x2716; not implemented yet):
* &#x2714; notifyclientleftview
* &#x2714; notifycliententerview
* &#x2714; notifyclientmoved
* &#x2714; notifytextmessage
* &#x2714; notifytokenused
* &#x2714; notifychanneledited
* &#x2714; notifychannelcreated
* &#x2714; notifychannelmoved
* &#x2714; notifychanneldeleted
* &#x2714; notifychanneldescriptionchanged
* &#x2714; notifychannelpasswordchanged
* &#x2714; notifyserveredited

**List of Commands** (&#x2714; implemented - &#x2716; not implemented yet):
* &#x2714; help
* &#x2714; quit
* &#x2714; login
* &#x2714; logout
* &#x2714; version
* &#x2714; hostinfo
* &#x2714; instanceinfo
* &#x2714; instanceedit
* &#x2714; bindinglist
* &#x2714; use
* &#x2714; serverlist
* &#x2714; serveridgetbyport
* &#x2714; serverdelete
* &#x2714; servercreate
* &#x2714; serverstart
* &#x2714; serverstop
* &#x2714; serverprocessstop
* &#x2714; serverinfo
* &#x2714; serverrequestconnectioninfo
* &#x2714; servertemppasswordadd
* &#x2714; servertemppassworddel
* &#x2714; servertemppasswordlist
* &#x2714; serveredit
* &#x2714; servergrouplist
* &#x2714; servergroupadd
* &#x2714; servergroupdel
* &#x2714; servergroupcopy
* &#x2714; servergrouprename
* &#x2714; servergrouppermlist
* &#x2714; servergroupaddperm
* &#x2714; servergroupdelperm
* &#x2714; servergroupaddclient
* &#x2714; servergroupdelclient
* &#x2714; servergroupclientlist
* &#x2714; servergroupsbyclientid
* &#x2714; servergroupautoaddperm
* &#x2714; servergroupautodelperm
* &#x2714; serversnapshotcreate
* &#x2714; serversnapshotdeploy
* &#x2714; servernotifyregister
* &#x2714; servernotifyunregister
* &#x2714; sendtextmessage
* &#x2714; logview
* &#x2714; logadd
* &#x2714; gm
* &#x2714; channellist
* &#x2714; channelinfo
* &#x2714; channelfind
* &#x2714; channelmove
* &#x2714; channelcreate
* &#x2714; channeldelete
* &#x2714; channeledit
* &#x2714; channelgrouplist
* &#x2714; channelgroupadd
* &#x2714; channelgroupdel
* &#x2714; channelgroupcopy
* &#x2714; channelgrouprename
* &#x2714; channelgroupaddperm
* &#x2714; channelgrouppermlist
* &#x2714; channelgroupdelperm
* &#x2714; channelgroupclientlist
* &#x2714; setclientchannelgroup
* &#x2714; tokenadd
* &#x2714; tokendelete
* &#x2714; tokenlist
* &#x2714; tokenuse
* &#x2714; channelpermlist
* &#x2714; channeladdperm
* &#x2714; channeldelperm
* &#x2714; clientlist
* &#x2714; clientinfo
* &#x2714; clientfind
* &#x2714; clientedit
* &#x2714; clientdblist
* &#x2714; clientdbinfo
* &#x2714; clientdbfind
* &#x2714; clientdbedit
* &#x2714; clientdbdelete
* &#x2714; clientgetids
* &#x2714; clientgetdbidfromuid
* &#x2714; clientgetnamefromuid
* &#x2714; clientgetuidfromclid
* &#x2714; clientgetnamefromdbid
* &#x2714; clientsetserverquerylogin
* &#x2714; clientupdate
* &#x2714; clientmove
* &#x2714; clientkick
* &#x2714; clientpoke
* &#x2714; clientpermlist
* &#x2714; clientaddperm
* &#x2714; clientdelperm
* &#x2714; channelclientpermlist
* &#x2714; channelclientaddperm
* &#x2714; channelclientdelperm
* &#x2714; permissionlist
* &#x2714; permidgetbyname
* &#x2714; permoverview
* &#x2714; permget
* &#x2714; permfind
* &#x2714; permreset
* &#x2714; privilegekeylist
* &#x2714; privilegekeyadd
* &#x2714; privilegekeydelete
* &#x2714; privilegekeyuse
* &#x2714; messagelist
* &#x2714; messageadd
* &#x2714; messagedel
* &#x2714; messageget
* &#x2714; messageupdateflag
* &#x2714; complainlist
* &#x2714; complainadd
* &#x2714; complaindelall
* &#x2714; complaindel
* &#x2714; banclient
* &#x2714; banlist
* &#x2714; banadd
* &#x2714; bandel
* &#x2714; bandelall
* &#x2714; ftinitupload
* &#x2714; ftinitdownload
* &#x2714; ftlist
* &#x2714; ftgetfilelist
* &#x2714; ftgetfileinfo
* &#x2714; ftstop
* &#x2714; ftdeletefile
* &#x2714; ftcreatedir
* &#x2714; ftrenamefile
* &#x2714; customsearch
* &#x2714; custominfo
* &#x2714; whoami
