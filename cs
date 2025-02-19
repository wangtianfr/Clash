[custom]
;设置规则标志位
;以下规则，按照从上往下的顺序遍历，优先命中上位规则
;修改顺序会影响分流效果

ruleset=🎯 全球直连,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Lan/Lan.list,28800
ruleset=🎯 全球直连,https://raw.githubusercontent.com/Aethersailor/Custom_OpenClash_Rules/main/rule/Custom_Direct.list,28800
ruleset=🚀 节点选择,https://raw.githubusercontent.com/Aethersailor/Custom_OpenClash_Rules/main/rule/Custom_Proxy.list,28800
ruleset=🎯 全球直连,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Direct/Direct.list,28800
ruleset=🎯 全球直连,[]GEOSITE,google-cn
ruleset=🚀 节点选择,https://raw.githubusercontent.com/ACL4SSR/ACL4SSR/master/Clash/Ruleset/GoogleCNProxyIP.list,28800
ruleset=🎯 全球直连,[]GEOSITE,steam@cn
ruleset=🎯 全球直连,https://raw.githubusercontent.com/Aethersailor/Custom_OpenClash_Rules/main/rule/Steam_CDN.list,28800
ruleset=🎯 全球直连,[]GEOSITE,category-public-tracker
ruleset=📲 Telegram,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Telegram/Telegram.list,28800
ruleset=🕊️ Twitter(X),[]GEOSITE,twitter
ruleset=🕊️ Twitter(X),[]GEOIP,twitter,no-resolve
ruleset=🤖 AI服务1,https://raw.githubusercontent.com/liandu2024/clash/refs/heads/main/AI.list,28800
ruleset=🤖 AI服务2,https://raw.githubusercontent.com/liandu2024/clash/refs/heads/main/AI2.list,28800
ruleset=🚀 GitHub,[]GEOSITE,github
ruleset=🚀 测速工具,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Speedtest/Speedtest.list,28800
ruleset=📹 YouTube,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/YouTube/YouTube.list,28800
ruleset=🎥 AppleTV+,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/refs/heads/master/rule/Clash/AppleTV/AppleTV.list,28800
ruleset=🍎 苹果服务,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Apple/Apple.list,28800
ruleset=Ⓜ️ 微软服务,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Microsoft/Microsoft.list,28800
ruleset=🎯 全球直连,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/XiaoMi/XiaoMi.list,28800
ruleset=📢 谷歌FCM,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/GoogleFCM/GoogleFCM.list,28800
ruleset=🇬 谷歌服务,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Google/Google.list,28800
ruleset=🎶 TikTok,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/TikTok/TikTok.list,28800
ruleset=🎥 Netflix,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Netflix/Netflix.list,28800
ruleset=🎥 DisneyPlus,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Disney/Disney.list,28800
ruleset=🎥 HBO,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/HBO/HBO.list,28800
ruleset=🎥 HBO,https://raw.githubusercontent.com/Aethersailor/Custom_OpenClash_Rules/refs/heads/main/rule/HBO_fix.list,28800
ruleset=🎥 PrimeVideo,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/refs/heads/master/rule/Clash/AmazonPrimeVideo/AmazonPrimeVideo.list,28800
ruleset=🎥 Emby,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Emby/Emby.list,28800
ruleset=🎥 Emby,https://raw.githubusercontent.com/ddgksf2013/Filter/refs/heads/master/Emby.list,28800
ruleset=🎻 Spotify,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Spotify/Spotify.list,28800
ruleset=📺 Bahamut,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Bahamut/Bahamut.list,28800
ruleset=🎶 网易音乐,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/NetEaseMusic/NetEaseMusic.list,28800
ruleset=📺 国内媒体,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/ChinaMedia/ChinaMedia.list,28800
ruleset=🎯 全球直连,https://raw.githubusercontent.com/Aethersailor/Custom_OpenClash_Rules/refs/heads/main/rule/IPTVMainland_Domain.list,28800
ruleset=🌎 国外媒体,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/GlobalMedia/GlobalMedia.list,28800
ruleset=🛒 国外电商,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/refs/heads/master/rule/Clash/Amazon/Amazon.list,28800
ruleset=🛒 国外电商,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/refs/heads/master/rule/Clash/AmazonIP/AmazonIP.list,28800
ruleset=🛒 国外电商,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/refs/heads/master/rule/Clash/Shopee/Shopee.list,28800
ruleset=🛒 国外电商,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Shopify/Shopify.list,28800
ruleset=🛒 国外电商,https://raw.githubusercontent.com/Aethersailor/Custom_OpenClash_Rules/refs/heads/main/rule/Ozon.list,28800
ruleset=🎮 游戏平台,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Epic/Epic.list,28800
ruleset=🎮 游戏平台,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/EA/EA.list,28800
ruleset=🎮 游戏平台,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Blizzard/Blizzard.list,28800
ruleset=🎮 游戏平台,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/UBI/UBI.list,28800
ruleset=🎮 游戏平台,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Sony/Sony.list,28800
ruleset=🎮 游戏平台,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Nintendo/Nintendo.list,28800
ruleset=🎮 Steam,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Steam/Steam.list,28800
ruleset=🚀 节点选择,[]GEOSITE,gfw
ruleset=🎯 全球直连,https://raw.githubusercontent.com/blackmatrix7/ios_rule_script/master/rule/Clash/Download/Download.list,28800
ruleset=🎯 全球直连,[]GEOSITE,cn
ruleset=🐟 漏网之鱼,[]FINAL
;设置规则标志位结束

;设置节点分组标志位
;节点地区分组参考本项目推荐机场而设立
custom_proxy_group=🚀 节点选择`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全
custom_proxy_group=♻️ 自动选择`url-test`.*`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=🚀 GitHub`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🎯 全球直连
custom_proxy_group=📲 Telegram`select`[]🚀 节点选择`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全
custom_proxy_group=🕊️ Twitter(X)`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全
custom_proxy_group=🤖 AI服务1`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择
custom_proxy_group=🤖 AI服务2`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择
custom_proxy_group=🎶 TikTok`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择`[]🎯 全球直连
custom_proxy_group=📹 YouTube`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择
custom_proxy_group=🎥 Netflix`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择
custom_proxy_group=🎥 DisneyPlus`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择
custom_proxy_group=🎥 HBO`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择`[]🎯 全球直连
custom_proxy_group=🎥 PrimeVideo`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择`[]🎯 全球直连
custom_proxy_group=🎥 AppleTV+`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择`[]🎯 全球直连
custom_proxy_group=🎥 Emby`select`[]🎯 全球直连`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择
custom_proxy_group=🎻 Spotify`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择`[]🎯 全球直连
custom_proxy_group=📺 Bahamut`select`[]台湾-低倍率`[]台湾家宽-低倍率`[]🚀 节点选择`[]🎯 全球直连
custom_proxy_group=🎶 网易音乐`select`[]🎯 全球直连`[]🚀 节点选择`(网易|音乐|解锁|Music|NetEase)
custom_proxy_group=📺 国内媒体`select`[]🎯 全球直连`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全
custom_proxy_group=🌎 国外媒体`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择`[]🎯 全球直连
custom_proxy_group=🛒 国外电商`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择`[]🎯 全球直连
custom_proxy_group=📢 谷歌FCM`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择`[]🎯 全球直连
custom_proxy_group=🇬 谷歌服务`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择`[]🎯 全球直连
custom_proxy_group=🍎 苹果服务`select`[]🎯 全球直连`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择
custom_proxy_group=Ⓜ️ 微软服务`select`[]🎯 全球直连`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择
custom_proxy_group=🎮 游戏平台`select`[]🎯 全球直连`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择
custom_proxy_group=🎮 Steam`select`[]🎯 全球直连`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择
custom_proxy_group=🚀 测速工具`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择
custom_proxy_group=🐟 漏网之鱼`select`[]全球-低倍率`[]全球-超低倍率`[]港澳-低倍率`[]港澳家宽-低倍率`[]港澳家宽-全`[]台湾-低倍率`[]台湾家宽-低倍率`[]台湾家宽-全`[]日韩台-低倍率``[]日韩台家宽-低倍率`[]日韩台家宽-全`[]新马-低倍率`[]新马家宽-低倍率`[]新马家宽-全`[]美国-低倍率`[]美国家宽-低倍率`[]美国家宽-全`[]加拿大-低倍率`[]加拿大家宽-低倍率`[]加拿大家宽-全`[]东南亚-低倍率`[]东南亚家宽-低倍率`[]东南亚家宽-全`[]🚀 节点选择`[]🎯 全球直连
custom_proxy_group=🎯 全球直连`select`[]DIRECT
custom_proxy_group=全球-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=全球-超低倍率`url-test`(0.3X)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=港澳-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(港|HK|hk|Hong Kong|HongKong|hongkong|深港|澳门|Macao|Macau).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=港澳家宽-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(香港家宽|澳门家宽|HKT|HKBN|i-Cable|CTM).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=港澳家宽-全`url-test`(香港家宽|澳门家宽|HKT|HKBN|i-Cable|CTM)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=台湾-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(台湾|TW).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=台湾家宽-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(台湾家宽|Hinet|Apol|SeenNet).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=台湾家宽-全`url-test`(台湾家宽|Hinet|Apol|SeenNet)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=日韩台-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(日本|韩国|台湾|TW|JP|KR).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=日韩台家宽-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X|斯洛伐克)).*(日本家宽|韩国家宽|台湾家宽|Hinet|Apol|SeenNet|SoftBank|KDDI|Sonet|Biglobe|SK|KT|LG|Sejong).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=日韩台家宽-全`url-test`(日本家宽|韩国家宽|台湾家宽|Hinet|Apol|SeenNet|SoftBank|KDDI|Sonet|Biglobe|SK|KT|LG|Sejong)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=新马-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(新加坡|马来|SG|MY).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=新马家宽-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(新加坡家宽|马来西亚家宽|Singtel|Telekom Malaysia|TM).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=新马家宽-全`url-test`(新加坡家宽|马来西亚家宽|Singtel|Telekom Malaysia|TM)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=美国-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(美国|US).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=美国家宽-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(美国-家宽|Verizon|AT&T|Comcast|Frontier).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=美国家宽-全`url-test`(美国-家宽|Verizon|AT&T|Comcast|Frontier)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=加拿大-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(加拿大|CA).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=加拿大家宽-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(加拿大家宽|Videotron).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=加拿大家宽-全`url-test`(加拿大家宽|Videotron)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=东南亚-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(马尔代夫|柬埔寨|泰国|缅甸|老挝|越南|菲律宾|印尼|Indonesia|PH|TH|Vietnam|Cambodia).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=东南亚家宽-低倍率`url-test`(^(?!.*?(2x|3x|4x|5x|10x|20x|2X|3X|4X|5X|10X|20X)).*(马尔代夫家宽|柬埔寨家宽|泰国家宽|缅甸家宽|老挝家宽|越南家宽|菲律宾家宽|印尼家宽|VNPT).*$)`https://cp.cloudflare.com/generate_204`300,,50
custom_proxy_group=东南亚家宽-全`url-test`(马尔代夫家宽|柬埔寨家宽|泰国家宽|缅甸家宽|老挝家宽|越南家宽|菲律宾家宽|印尼家宽|VNPT)`https://cp.cloudflare.com/generate_204`300,,50
;设置分组标志位

;下方参数请勿修改
enable_rule_generator=true
overwrite_original_rules=true
