using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Timers;
using Omt.Net.Http;

namespace UnityEngine.ServerExtensions
{
	// Token: 0x0200045B RID: 1115
	public class ServerVerificationModule : MonoBehaviour
	{
		// Token: 0x06007B36 RID: 31542 RVA: 0x002373CC File Offset: 0x002355CC
		// Note: this type is marked as 'beforefieldinit'.
		static ServerVerificationModule()
		{
			Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.ServerExtensions", "ServerVerificationModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr);
			ServerVerificationModule.NativeFieldInfoPtr_m_HttpRequester = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, "m_HttpRequester");
			ServerVerificationModule.NativeFieldInfoPtr_m_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, "m_Timer");
			ServerVerificationModule.NativeFieldInfoPtr_m_SteamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, "m_SteamId");
			ServerVerificationModule.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, "<Instance>k__BackingField");
			ServerVerificationModule.NativeFieldInfoPtr__MCLinkageData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, "<MCLinkageData>k__BackingField");
			ServerVerificationModule.NativeMethodInfoPtr_get_Instance_Public_Static_get_ServerVerificationModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687951);
			ServerVerificationModule.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ServerVerificationModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687952);
			ServerVerificationModule.NativeMethodInfoPtr_get_MCLinkageData_Public_get_MCResponseModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687953);
			ServerVerificationModule.NativeMethodInfoPtr_set_MCLinkageData_Private_set_Void_MCResponseModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687954);
			ServerVerificationModule.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687955);
			ServerVerificationModule.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687956);
			ServerVerificationModule.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687957);
			ServerVerificationModule.NativeMethodInfoPtr_StartTimingModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687958);
			ServerVerificationModule.NativeMethodInfoPtr_StartMCLinkageModule_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687959);
			ServerVerificationModule.NativeMethodInfoPtr_SendRequestLoop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687960);
			ServerVerificationModule.NativeMethodInfoPtr_RequestMCKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687961);
			ServerVerificationModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687962);
			ServerVerificationModule.NativeMethodInfoPtr__StartTimingModule_b__14_0_Private_Void_Object_ElapsedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687963);
			ServerVerificationModule.NativeMethodInfoPtr__StartTimingModule_b__14_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687964);
			ServerVerificationModule.NativeMethodInfoPtr__RequestMCKey_b__17_0_Private_Void_HttpResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr, 100687965);
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x06007B37 RID: 31543 RVA: 0x0023758C File Offset: 0x0023578C
		// (set) Token: 0x06007B38 RID: 31544 RVA: 0x002375C0 File Offset: 0x002357C0
		public unsafe static ServerVerificationModule Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295700, XrefRangeEnd = 295702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr_get_Instance_Public_Static_get_ServerVerificationModule_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerVerificationModule>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295702, XrefRangeEnd = 295706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ServerVerificationModule_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x06007B39 RID: 31545 RVA: 0x002375F8 File Offset: 0x002357F8
		// (set) Token: 0x06007B3A RID: 31546 RVA: 0x00237638 File Offset: 0x00235838
		public unsafe MCResponseModel MCLinkageData
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr_get_MCLinkageData_Public_get_MCResponseModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MCResponseModel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr_set_MCLinkageData_Private_set_Void_MCResponseModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x0023767C File Offset: 0x0023587C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295706, XrefRangeEnd = 295722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3C RID: 31548 RVA: 0x002376B0 File Offset: 0x002358B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295722, XrefRangeEnd = 295723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x002376E4 File Offset: 0x002358E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295729, RefRangeEnd = 295730, XrefRangeStart = 295723, XrefRangeEnd = 295729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x00237718 File Offset: 0x00235918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295730, XrefRangeEnd = 295746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTimingModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr_StartTimingModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3F RID: 31551 RVA: 0x0023774C File Offset: 0x0023594C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295746, XrefRangeEnd = 295767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMCLinkageModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr_StartMCLinkageModule_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B40 RID: 31552 RVA: 0x00237780 File Offset: 0x00235980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295767, XrefRangeEnd = 295787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRequestLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr_SendRequestLoop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x002377B4 File Offset: 0x002359B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestMCKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr_RequestMCKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x002377E8 File Offset: 0x002359E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295787, XrefRangeEnd = 295804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerVerificationModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerVerificationModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x00237824 File Offset: 0x00235A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _StartTimingModule_b__14_0(Object s, ElapsedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr__StartTimingModule_b__14_0_Private_Void_Object_ElapsedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x00237878 File Offset: 0x00235A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295804, XrefRangeEnd = 295806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _StartTimingModule_b__14_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr__StartTimingModule_b__14_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x002378AC File Offset: 0x00235AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295806, XrefRangeEnd = 295813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RequestMCKey_b__17_0(HttpResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(response));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVerificationModule.NativeMethodInfoPtr__RequestMCKey_b__17_0_Private_Void_HttpResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B46 RID: 31558 RVA: 0x00042780 File Offset: 0x00040980
		public ServerVerificationModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x06007B47 RID: 31559 RVA: 0x002378F4 File Offset: 0x00235AF4
		// (set) Token: 0x06007B48 RID: 31560 RVA: 0x00042789 File Offset: 0x00040989
		public unsafe HttpRequester m_HttpRequester
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVerificationModule.NativeFieldInfoPtr_m_HttpRequester);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequester>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVerificationModule.NativeFieldInfoPtr_m_HttpRequester), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x06007B49 RID: 31561 RVA: 0x00237924 File Offset: 0x00235B24
		// (set) Token: 0x06007B4A RID: 31562 RVA: 0x000427A8 File Offset: 0x000409A8
		public unsafe Timer m_Timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVerificationModule.NativeFieldInfoPtr_m_Timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVerificationModule.NativeFieldInfoPtr_m_Timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x06007B4B RID: 31563 RVA: 0x00237954 File Offset: 0x00235B54
		// (set) Token: 0x06007B4C RID: 31564 RVA: 0x000427C7 File Offset: 0x000409C7
		public unsafe string m_SteamId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVerificationModule.NativeFieldInfoPtr_m_SteamId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVerificationModule.NativeFieldInfoPtr_m_SteamId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x06007B4D RID: 31565 RVA: 0x0023797C File Offset: 0x00235B7C
		// (set) Token: 0x06007B4E RID: 31566 RVA: 0x000427E6 File Offset: 0x000409E6
		public unsafe static ServerVerificationModule _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServerVerificationModule.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerVerificationModule>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServerVerificationModule.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x06007B4F RID: 31567 RVA: 0x002379A4 File Offset: 0x00235BA4
		// (set) Token: 0x06007B50 RID: 31568 RVA: 0x000427F8 File Offset: 0x000409F8
		public unsafe MCResponseModel _MCLinkageData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVerificationModule.NativeFieldInfoPtr__MCLinkageData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MCResponseModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVerificationModule.NativeFieldInfoPtr__MCLinkageData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005113 RID: 20755
		private static readonly IntPtr NativeFieldInfoPtr_m_HttpRequester;

		// Token: 0x04005114 RID: 20756
		private static readonly IntPtr NativeFieldInfoPtr_m_Timer;

		// Token: 0x04005115 RID: 20757
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamId;

		// Token: 0x04005116 RID: 20758
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04005117 RID: 20759
		private static readonly IntPtr NativeFieldInfoPtr__MCLinkageData_k__BackingField;

		// Token: 0x04005118 RID: 20760
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ServerVerificationModule_0;

		// Token: 0x04005119 RID: 20761
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ServerVerificationModule_0;

		// Token: 0x0400511A RID: 20762
		private static readonly IntPtr NativeMethodInfoPtr_get_MCLinkageData_Public_get_MCResponseModel_0;

		// Token: 0x0400511B RID: 20763
		private static readonly IntPtr NativeMethodInfoPtr_set_MCLinkageData_Private_set_Void_MCResponseModel_0;

		// Token: 0x0400511C RID: 20764
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400511D RID: 20765
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400511E RID: 20766
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x0400511F RID: 20767
		private static readonly IntPtr NativeMethodInfoPtr_StartTimingModule_Private_Void_0;

		// Token: 0x04005120 RID: 20768
		private static readonly IntPtr NativeMethodInfoPtr_StartMCLinkageModule_Private_Void_0;

		// Token: 0x04005121 RID: 20769
		private static readonly IntPtr NativeMethodInfoPtr_SendRequestLoop_Private_Void_0;

		// Token: 0x04005122 RID: 20770
		private static readonly IntPtr NativeMethodInfoPtr_RequestMCKey_Private_Void_0;

		// Token: 0x04005123 RID: 20771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005124 RID: 20772
		private static readonly IntPtr NativeMethodInfoPtr__StartTimingModule_b__14_0_Private_Void_Object_ElapsedEventArgs_0;

		// Token: 0x04005125 RID: 20773
		private static readonly IntPtr NativeMethodInfoPtr__StartTimingModule_b__14_1_Private_Void_0;

		// Token: 0x04005126 RID: 20774
		private static readonly IntPtr NativeMethodInfoPtr__RequestMCKey_b__17_0_Private_Void_HttpResponse_0;
	}
}
