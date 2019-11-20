# sorryaboutyourvisualizer

Very early build of the MixPlay controlled visualizer.

When playing it from Unity, it will ask you to connect it to your Mixer account - after that, you should be able to control different aspects of the visualizer from your MixPlay board [you don't have to be streaming].

Not all buttons work, because things are constantly changing, so don't bother with reporting bugs as, again, this is nowhere near done.

Stream channel dedicated to visualizer:
https://mixer.com/sorryaboutyourbeats

Discord for discussion:
https://discord.gg/sorryaboutyourcats

Trello board for updates:
https://trello.com/b/8uH06SGr/visualizer

💜

---

If you're upgrading from v.05 or need to change the Mixer account linked to sorryaboutyourvisualizer:

* Windows key + R<br>
* Type regedit hit enter<br>
* Expand:<br>
  * Computer<br>
  * HKEY_USERS<br>
  * [find your user name via SID]<br>
  * Software<br>
  * sorryaboutyourcats<br>
  * sorryaboutyourvisualizer
    * ERASE MixerInteractive-AuthToken_h2649052216<br>
    * ERASE MixerInteractive-RefreshToken_h621846253<br>
<br>
Please be careful with the registry.<br>
Type this in cmd to get your SID: *WMIC useraccount get name,sid*<br>
[For more help, see: https://www.wikihow.com/Find-a-Users-SID-on-Windows]
