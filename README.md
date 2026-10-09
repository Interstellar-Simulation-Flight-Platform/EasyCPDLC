# EasyCPDLC ISFP

一个为 [ISFP](https://www.flyisfp.com)（Interstellar Simulation Flight Platform）连飞平台做的 CPDLC 客户端，走 [Hoppie ACARS](https://www.hoppie.nl/acars/) 网络。

飞机本身没有 CPDLC？用它照样能收放行、发电报、跟管制要直飞。

> 基于 [josh-seagrave/EasyCPDLC](https://github.com/josh-seagrave/EasyCPDLC) 修改而来，按 GPL v3 协议同样开源。

## 能干什么

- 登录管制单位、申请数据链放行（DCL）
- 和其他 CPDLC 用户收发 Telex 电报
- 输入 Simbrief 用户名，自动读取航班计划预填表单
- 连接 FSUIPC/XPUIPC 自动读取飞行状态
- 收到新电文时窗口闪烁、播放提示音
- 窗口可置顶，全屏飞行时也能看到

## 使用前准备

系统要求：Windows 10/11 64 位，装好 [.NET Desktop Runtime 10.0](https://dotnet.microsoft.com/download/dotnet/10.0)。

启动后你需要填三样东西：

1. **ISFP CID** — 你的 ISFP 飞行员编号
2. **Hoppie Logon Code** — 在 [Hoppie 注册页](https://www.hoppie.nl/acars/system/register.html) 免费申请
3. Simbrief 用户名（可选，不填就要手动输入机场和机型）

在 ISFP 连线并提交飞行计划后，点 **CONNECT**，程序会从 ISFP API 找到你的航班（呼号、机型、起降机场、巡航高度），自动填进各个表单。

最新版本在 [Releases](../../releases) 页面下载。

## 常见问题

**点了 CONNECT 提示 ISFP ERROR？**
先确认你在 ISFP 已经连线、飞行计划已提交，然后等 60 秒再试。

**CPDLC 是什么？**
管制员和飞行员之间用文本电报代替语音通信，跨洋飞行时常用。

**遇到 Bug？**
请[提交 Issue](../../issues)，带上复现步骤和日志（EasyCPDLCLog.txt）。

## 自己编译

需要 .NET 10 SDK 和 Windows。

```bash
git clone https://github.com/Interstellar-Simulation-Flight-Platform/EasyCPDLC.git
cd EasyCPDLC

dotnet build EasyCPDLC.sln -c Release

# 单文件发布
dotnet publish EasyCPDLC/EasyCPDLC.csproj -c Release -r win-x64
```

## 许可证

[GPL v3](LICENSE)。原项目 [josh-seagrave/EasyCPDLC](https://github.com/josh-seagrave/EasyCPDLC)，感谢 Josh Seagrave 的贡献，以及 [Hoppie ACARS](https://www.hoppie.nl/acars/)、[Simbrief](https://www.simbrief.com/) 提供的数据服务。
