using System;
using DEYU.Singletons;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Timers;
using Omt.Net.Http;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace PrototypingManagers
{
	// Token: 0x0200004A RID: 74
	public class GlobalDebugConsole : MonoSingletonPersistant<GlobalDebugConsole>
	{
		// Token: 0x060008FD RID: 2301 RVA: 0x000BA590 File Offset: 0x000B8790
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalDebugConsole()
		{
			Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrototypingManagers", "GlobalDebugConsole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr);
			GlobalDebugConsole.NativeFieldInfoPtr_SyncMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "SyncMinutes");
			GlobalDebugConsole.NativeFieldInfoPtr_couldReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "couldReset");
			GlobalDebugConsole.NativeFieldInfoPtr_mainScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "mainScene");
			GlobalDebugConsole.NativeFieldInfoPtr_loadScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "loadScene");
			GlobalDebugConsole.NativeFieldInfoPtr_logMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "logMessages");
			GlobalDebugConsole.NativeFieldInfoPtr_m_LoginDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "m_LoginDevice");
			GlobalDebugConsole.NativeFieldInfoPtr_m_LoginName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "m_LoginName");
			GlobalDebugConsole.NativeFieldInfoPtr_m_Requester = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "m_Requester");
			GlobalDebugConsole.NativeFieldInfoPtr_m_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "m_Timer");
			GlobalDebugConsole.NativeFieldInfoPtr_m_UpdateAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "m_UpdateAddress");
			GlobalDebugConsole.NativeFieldInfoPtr_scrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "scrollPosition");
			GlobalDebugConsole.NativeFieldInfoPtr_shouldOnGUIAudioStatusShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "shouldOnGUIAudioStatusShown");
			GlobalDebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "shouldOnGUIBuffConsoleShown");
			GlobalDebugConsole.NativeFieldInfoPtr_showError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "showError");
			GlobalDebugConsole.NativeFieldInfoPtr_showNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "showNormal");
			GlobalDebugConsole.NativeFieldInfoPtr_showWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "showWarning");
			GlobalDebugConsole.NativeFieldInfoPtr__EnableConsole_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "<EnableConsole>k__BackingField");
			GlobalDebugConsole.NativeMethodInfoPtr_get_EnableConsole_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664747);
			GlobalDebugConsole.NativeMethodInfoPtr_set_EnableConsole_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664748);
			GlobalDebugConsole.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664749);
			GlobalDebugConsole.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664750);
			GlobalDebugConsole.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664751);
			GlobalDebugConsole.NativeMethodInfoPtr_GetAddress_Public_String_AddressType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664752);
			GlobalDebugConsole.NativeMethodInfoPtr_Initialize_Public_Void_HttpRequester_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664753);
			GlobalDebugConsole.NativeMethodInfoPtr_Timer_Elapsed_Private_Void_Object_ElapsedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664754);
			GlobalDebugConsole.NativeMethodInfoPtr_OnLogMessageRecived_Private_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664755);
			GlobalDebugConsole.NativeMethodInfoPtr_ShowAudioSystem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664756);
			GlobalDebugConsole.NativeMethodInfoPtr_ShowDebugConsole_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664757);
			GlobalDebugConsole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, 100664758);
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x000BA804 File Offset: 0x000B8A04
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x000BA834 File Offset: 0x000B8A34
		public unsafe static bool EnableConsole
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36576, XrefRangeEnd = 36580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr_get_EnableConsole_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36580, XrefRangeEnd = 36584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr_set_EnableConsole_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000BA868 File Offset: 0x000B8A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36584, XrefRangeEnd = 36602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000BA89C File Offset: 0x000B8A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36602, XrefRangeEnd = 36623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000BA8D0 File Offset: 0x000B8AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36623, XrefRangeEnd = 36742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000BA904 File Offset: 0x000B8B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36742, XrefRangeEnd = 36744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAddress(GlobalDebugConsole.AddressType addressType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref addressType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr_GetAddress_Public_String_AddressType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000BA948 File Offset: 0x000B8B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36744, XrefRangeEnd = 36771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(HttpRequester httpRequester, string name, string deviceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(httpRequester);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deviceId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr_Initialize_Public_Void_HttpRequester_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000BA9B0 File Offset: 0x000B8BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36771, XrefRangeEnd = 36786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Timer_Elapsed(Il2CppSystem.Object sender, ElapsedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr_Timer_Elapsed_Private_Void_Object_ElapsedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000BAA04 File Offset: 0x000B8C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36786, XrefRangeEnd = 36803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLogMessageRecived(string condition, string stackTrace, LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr_OnLogMessageRecived_Private_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000BAA68 File Offset: 0x000B8C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36803, XrefRangeEnd = 36814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowAudioSystem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr_ShowAudioSystem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000BAA9C File Offset: 0x000B8C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37012, RefRangeEnd = 37013, XrefRangeStart = 36814, XrefRangeEnd = 37012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowDebugConsole()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr_ShowDebugConsole_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000BAAD0 File Offset: 0x000B8CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37013, XrefRangeEnd = 37024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlobalDebugConsole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0000732A File Offset: 0x0000552A
		public GlobalDebugConsole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x000BAB0C File Offset: 0x000B8D0C
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x00007333 File Offset: 0x00005533
		public unsafe static int SyncMinutes
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GlobalDebugConsole.NativeFieldInfoPtr_SyncMinutes, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalDebugConsole.NativeFieldInfoPtr_SyncMinutes, (void*)(&value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x000BAB28 File Offset: 0x000B8D28
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x00007341 File Offset: 0x00005541
		public unsafe bool couldReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_couldReset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_couldReset)) = value;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x000BAB50 File Offset: 0x000B8D50
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x0000735C File Offset: 0x0000555C
		public unsafe AssetReference mainScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_mainScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_mainScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x000BAB80 File Offset: 0x000B8D80
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x0000737B File Offset: 0x0000557B
		public unsafe AssetReference loadScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_loadScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_loadScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x000BABB0 File Offset: 0x000B8DB0
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x0000739A File Offset: 0x0000559A
		public unsafe Queue<GlobalDebugConsole.LogMessage> logMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_logMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<GlobalDebugConsole.LogMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_logMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x000BABE0 File Offset: 0x000B8DE0
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x000073B9 File Offset: 0x000055B9
		public unsafe string m_LoginDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_m_LoginDevice);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_m_LoginDevice), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x000BAC08 File Offset: 0x000B8E08
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x000073D8 File Offset: 0x000055D8
		public unsafe string m_LoginName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_m_LoginName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_m_LoginName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x000BAC30 File Offset: 0x000B8E30
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x000073F7 File Offset: 0x000055F7
		public unsafe HttpRequester m_Requester
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_m_Requester);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequester>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_m_Requester), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x000BAC60 File Offset: 0x000B8E60
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00007416 File Offset: 0x00005616
		public unsafe Timer m_Timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_m_Timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_m_Timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x000BAC90 File Offset: 0x000B8E90
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00007435 File Offset: 0x00005635
		public unsafe string m_UpdateAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_m_UpdateAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_m_UpdateAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x000BACB8 File Offset: 0x000B8EB8
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00007454 File Offset: 0x00005654
		public unsafe Vector2 scrollPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_scrollPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_scrollPosition)) = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x000BACE0 File Offset: 0x000B8EE0
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x0000746F File Offset: 0x0000566F
		public unsafe bool shouldOnGUIAudioStatusShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_shouldOnGUIAudioStatusShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_shouldOnGUIAudioStatusShown)) = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x000BAD08 File Offset: 0x000B8F08
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x0000748A File Offset: 0x0000568A
		public unsafe bool shouldOnGUIBuffConsoleShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown)) = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x000BAD30 File Offset: 0x000B8F30
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x000074A5 File Offset: 0x000056A5
		public unsafe bool showError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_showError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_showError)) = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x000BAD58 File Offset: 0x000B8F58
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x000074C0 File Offset: 0x000056C0
		public unsafe bool showNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_showNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_showNormal)) = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x000BAD80 File Offset: 0x000B8F80
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x000074DB File Offset: 0x000056DB
		public unsafe bool showWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_showWarning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.NativeFieldInfoPtr_showWarning)) = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x000BADA8 File Offset: 0x000B8FA8
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x000074F6 File Offset: 0x000056F6
		public unsafe static bool _EnableConsole_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GlobalDebugConsole.NativeFieldInfoPtr__EnableConsole_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalDebugConsole.NativeFieldInfoPtr__EnableConsole_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_SyncMinutes;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeFieldInfoPtr_couldReset;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeFieldInfoPtr_mainScene;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeFieldInfoPtr_loadScene;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeFieldInfoPtr_logMessages;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeFieldInfoPtr_m_LoginDevice;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr_m_LoginName;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr_m_Requester;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr_m_Timer;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateAddress;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr_scrollPosition;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_shouldOnGUIAudioStatusShown;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_showError;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_showNormal;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr_showWarning;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr__EnableConsole_k__BackingField;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableConsole_Public_Static_get_Boolean_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableConsole_Private_Static_set_Void_Boolean_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_GetAddress_Public_String_AddressType_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_HttpRequester_String_String_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_Timer_Elapsed_Private_Void_Object_ElapsedEventArgs_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_OnLogMessageRecived_Private_Void_String_String_LogType_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_ShowAudioSystem_Private_Void_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_ShowDebugConsole_Private_Void_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000507 RID: 1287
		public enum AddressType
		{
			// Token: 0x0400566C RID: 22124
			Login,
			// Token: 0x0400566D RID: 22125
			Update
		}

		// Token: 0x02000508 RID: 1288
		public sealed class LogMessage : ValueType
		{
			// Token: 0x060083EF RID: 33775 RVA: 0x00250B98 File Offset: 0x0024ED98
			// Note: this type is marked as 'beforefieldinit'.
			static LogMessage()
			{
				Il2CppClassPointerStore<GlobalDebugConsole.LogMessage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "LogMessage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalDebugConsole.LogMessage>.NativeClassPtr);
				GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole.LogMessage>.NativeClassPtr, "condition");
				GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_stackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole.LogMessage>.NativeClassPtr, "stackTrace");
				GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole.LogMessage>.NativeClassPtr, "type");
				GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole.LogMessage>.NativeClassPtr, "time");
				GlobalDebugConsole.LogMessage.NativeMethodInfoPtr__ctor_Public_Void_String_String_LogType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole.LogMessage>.NativeClassPtr, 100664760);
			}

			// Token: 0x060083F0 RID: 33776 RVA: 0x00250C28 File Offset: 0x0024EE28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36573, XrefRangeEnd = 36576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LogMessage(string condition, string stackTrace, LogType type, string time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalDebugConsole.LogMessage>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(time);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.LogMessage.NativeMethodInfoPtr__ctor_Public_Void_String_String_LogType_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060083F1 RID: 33777 RVA: 0x000471A8 File Offset: 0x000453A8
			public LogMessage(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060083F2 RID: 33778 RVA: 0x000471B1 File Offset: 0x000453B1
			public LogMessage() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalDebugConsole.LogMessage>.NativeClassPtr))
			{
			}

			// Token: 0x17002C57 RID: 11351
			// (get) Token: 0x060083F3 RID: 33779 RVA: 0x00250CAC File Offset: 0x0024EEAC
			// (set) Token: 0x060083F4 RID: 33780 RVA: 0x000471C3 File Offset: 0x000453C3
			public unsafe string condition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_condition);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_condition), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002C58 RID: 11352
			// (get) Token: 0x060083F5 RID: 33781 RVA: 0x00250CD4 File Offset: 0x0024EED4
			// (set) Token: 0x060083F6 RID: 33782 RVA: 0x000471E2 File Offset: 0x000453E2
			public unsafe string stackTrace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_stackTrace);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_stackTrace), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002C59 RID: 11353
			// (get) Token: 0x060083F7 RID: 33783 RVA: 0x00250CFC File Offset: 0x0024EEFC
			// (set) Token: 0x060083F8 RID: 33784 RVA: 0x00047201 File Offset: 0x00045401
			public unsafe LogType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x17002C5A RID: 11354
			// (get) Token: 0x060083F9 RID: 33785 RVA: 0x00250D24 File Offset: 0x0024EF24
			// (set) Token: 0x060083FA RID: 33786 RVA: 0x0004721C File Offset: 0x0004541C
			public unsafe string time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_time);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalDebugConsole.LogMessage.NativeFieldInfoPtr_time), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400566E RID: 22126
			private static readonly IntPtr NativeFieldInfoPtr_condition;

			// Token: 0x0400566F RID: 22127
			private static readonly IntPtr NativeFieldInfoPtr_stackTrace;

			// Token: 0x04005670 RID: 22128
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04005671 RID: 22129
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04005672 RID: 22130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_LogType_String_0;
		}

		// Token: 0x02000509 RID: 1289
		[ObfuscatedName("PrototypingManagers.GlobalDebugConsole+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060083FB RID: 33787 RVA: 0x00250D4C File Offset: 0x0024EF4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GlobalDebugConsole.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalDebugConsole>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalDebugConsole.__c>.NativeClassPtr);
				GlobalDebugConsole.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole.__c>.NativeClassPtr, "<>9");
				GlobalDebugConsole.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole.__c>.NativeClassPtr, "<>9__29_0");
				GlobalDebugConsole.__c.NativeFieldInfoPtr___9__29_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole.__c>.NativeClassPtr, "<>9__29_1");
				GlobalDebugConsole.__c.NativeFieldInfoPtr___9__29_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalDebugConsole.__c>.NativeClassPtr, "<>9__29_2");
				GlobalDebugConsole.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole.__c>.NativeClassPtr, 100664762);
				GlobalDebugConsole.__c.NativeMethodInfoPtr__ShowDebugConsole_b__29_0_Internal_Boolean_LogMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole.__c>.NativeClassPtr, 100664763);
				GlobalDebugConsole.__c.NativeMethodInfoPtr__ShowDebugConsole_b__29_1_Internal_Boolean_LogMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole.__c>.NativeClassPtr, 100664764);
				GlobalDebugConsole.__c.NativeMethodInfoPtr__ShowDebugConsole_b__29_2_Internal_Boolean_LogMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalDebugConsole.__c>.NativeClassPtr, 100664765);
			}

			// Token: 0x060083FC RID: 33788 RVA: 0x00250E18 File Offset: 0x0024F018
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalDebugConsole.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060083FD RID: 33789 RVA: 0x00250E54 File Offset: 0x0024F054
			[CallerCount(0)]
			public unsafe bool _ShowDebugConsole_b__29_0(GlobalDebugConsole.LogMessage x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.__c.NativeMethodInfoPtr__ShowDebugConsole_b__29_0_Internal_Boolean_LogMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060083FE RID: 33790 RVA: 0x00250EA8 File Offset: 0x0024F0A8
			[CallerCount(0)]
			public unsafe bool _ShowDebugConsole_b__29_1(GlobalDebugConsole.LogMessage x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.__c.NativeMethodInfoPtr__ShowDebugConsole_b__29_1_Internal_Boolean_LogMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060083FF RID: 33791 RVA: 0x00250EFC File Offset: 0x0024F0FC
			[CallerCount(0)]
			public unsafe bool _ShowDebugConsole_b__29_2(GlobalDebugConsole.LogMessage x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalDebugConsole.__c.NativeMethodInfoPtr__ShowDebugConsole_b__29_2_Internal_Boolean_LogMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008400 RID: 33792 RVA: 0x0004723B File Offset: 0x0004543B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C5B RID: 11355
			// (get) Token: 0x06008401 RID: 33793 RVA: 0x00250F50 File Offset: 0x0024F150
			// (set) Token: 0x06008402 RID: 33794 RVA: 0x00047244 File Offset: 0x00045444
			public unsafe static GlobalDebugConsole.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GlobalDebugConsole.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalDebugConsole.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GlobalDebugConsole.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C5C RID: 11356
			// (get) Token: 0x06008403 RID: 33795 RVA: 0x00250F78 File Offset: 0x0024F178
			// (set) Token: 0x06008404 RID: 33796 RVA: 0x00047256 File Offset: 0x00045456
			public unsafe static Func<GlobalDebugConsole.LogMessage, bool> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GlobalDebugConsole.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GlobalDebugConsole.LogMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GlobalDebugConsole.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C5D RID: 11357
			// (get) Token: 0x06008405 RID: 33797 RVA: 0x00250FA0 File Offset: 0x0024F1A0
			// (set) Token: 0x06008406 RID: 33798 RVA: 0x00047268 File Offset: 0x00045468
			public unsafe static Func<GlobalDebugConsole.LogMessage, bool> __9__29_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GlobalDebugConsole.__c.NativeFieldInfoPtr___9__29_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GlobalDebugConsole.LogMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GlobalDebugConsole.__c.NativeFieldInfoPtr___9__29_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C5E RID: 11358
			// (get) Token: 0x06008407 RID: 33799 RVA: 0x00250FC8 File Offset: 0x0024F1C8
			// (set) Token: 0x06008408 RID: 33800 RVA: 0x0004727A File Offset: 0x0004547A
			public unsafe static Func<GlobalDebugConsole.LogMessage, bool> __9__29_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GlobalDebugConsole.__c.NativeFieldInfoPtr___9__29_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GlobalDebugConsole.LogMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GlobalDebugConsole.__c.NativeFieldInfoPtr___9__29_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005673 RID: 22131
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005674 RID: 22132
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x04005675 RID: 22133
			private static readonly IntPtr NativeFieldInfoPtr___9__29_1;

			// Token: 0x04005676 RID: 22134
			private static readonly IntPtr NativeFieldInfoPtr___9__29_2;

			// Token: 0x04005677 RID: 22135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005678 RID: 22136
			private static readonly IntPtr NativeMethodInfoPtr__ShowDebugConsole_b__29_0_Internal_Boolean_LogMessage_0;

			// Token: 0x04005679 RID: 22137
			private static readonly IntPtr NativeMethodInfoPtr__ShowDebugConsole_b__29_1_Internal_Boolean_LogMessage_0;

			// Token: 0x0400567A RID: 22138
			private static readonly IntPtr NativeMethodInfoPtr__ShowDebugConsole_b__29_2_Internal_Boolean_LogMessage_0;
		}
	}
}
