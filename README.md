# bcandc---EXILED
 A chat plugin About exiled SCPSL
```
        [Description("插件是否打开")]
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("全体打字的字幕 有可定义的参数 如:1. tcolor是指玩家团队颜色 2. name 玩家名字 3.(必须) mes 玩家所发送的消息")]
        public string BcText { get; set; } = " [全体]<color=tcolor>[name]</color>: mes";
        [Description("全体打字的时间")]
        public int Bctime { get; set; } = 7;
        [Description("团队打字的字幕 有可定义的参数 如:1. tcolor是指玩家团队颜色 2. name 玩家名字 3.(必须) mes 玩家所发送的消息 4.rname 玩家角色名称")]
        public string cText { get; set; } = " [团队]<color=tcolor>[rname]</color>name: mes";
        [Description("团队打字的时间")]
        public int ctime { get; set; } = 7;
```

打字聊天插件 

只是简单的广播下

用bc,c即可打字
