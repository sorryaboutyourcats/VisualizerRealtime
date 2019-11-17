sorryaboutyourvisualizer

Very early build of the MixPlay controlled visualizer.

When playing it from Unity, it will ask you to connect it to your Mixer account - after that, you should be able to control different aspects of the visualizer from your MixPlay board [you don't have to be streaming].

Not all buttons work, because things are constantly changing, so don't bother with reporting bugs as, again, this is nowhere near done.

Discord for discussion:
https://discord.gg/sorryaboutyourcats

Trello board for updates:
https://trello.com/b/8uH06SGr/visualizer

💜

---

If you need to change the Mixer account linked to sorryaboutyourvisualizer:

Windows key + R<br>
Type RegEdit hit enter<br>
Expand:<br>
 -Computer<br>
  -HKEY_USERS<br>
   -[find your user name via SID]<br>
    -Software<br>
     -sorryaboutyourcats<br>
      -ERASE MixerInteractive-AuthToken_X<br>
      -ERASE MixerInteractive-RefreshToken_X<br>
<br>
Please be careful messing with the registry.<br>
[If you need help converting the SID, use http://www.joeware.net/freetools/tools/sidtoname/index.htm]
