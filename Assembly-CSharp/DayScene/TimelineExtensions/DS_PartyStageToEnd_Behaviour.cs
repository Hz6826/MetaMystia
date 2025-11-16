using System;
using Common;
using Common.TimelineExtestion;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200014D RID: 333
	public class DS_PartyStageToEnd_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x060026BB RID: 9915 RVA: 0x00120064 File Offset: 0x0011E264
		// Note: this type is marked as 'beforefieldinit'.
		static DS_PartyStageToEnd_Behaviour()
		{
			Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_PartyStageToEnd_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr);
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlcPartyStageKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "dlcPartyStageKey");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlcCGEventKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "dlcCGEventKey");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_mainKizuna = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "mainKizuna");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc1Kizuna = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "dlc1Kizuna");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc2Kizuna = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "dlc2Kizuna");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc3Kizuna = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "dlc3Kizuna");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc4Kizuna = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "dlc4Kizuna");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc5Kizuna = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "dlc5Kizuna");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_mainStory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "mainStory");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_readyDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "readyDialog");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_newMusicReadyDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "newMusicReadyDialog");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_startDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "startDialog");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_extraStartDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "extraStartDialog");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_acceptAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "acceptAddFrames");
			DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_refuseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "refuseAddFrames");
			DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, 100670212);
			DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr_OnBehaviourEnterAsync_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, 100670213);
			DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr_ToEnd_Private_Void_StaffScenePlayBackIndicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, 100670214);
			DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr_IsAllKizunaMaxLevel_Private_Static_Boolean_IReadOnlyCollection_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, 100670215);
			DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr_GetTitle_Private_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, 100670216);
			DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, 100670217);
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x00120238 File Offset: 0x0011E438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90629, XrefRangeEnd = 90635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00120274 File Offset: 0x0011E474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90635, XrefRangeEnd = 90640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OnBehaviourEnterAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr_OnBehaviourEnterAsync_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x001202B0 File Offset: 0x0011E4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90640, XrefRangeEnd = 90656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToEnd(SceneDirector.StaffScenePlayBackIndicator dlcIndicator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dlcIndicator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr_ToEnd_Private_Void_StaffScenePlayBackIndicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x001202F0 File Offset: 0x0011E4F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 90660, RefRangeEnd = 90666, XrefRangeStart = 90656, XrefRangeEnd = 90660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAllKizunaMaxLevel(IReadOnlyCollection<int> lv5Kizuna, Il2CppStructArray<int> specialNPCs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv5Kizuna);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialNPCs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr_IsAllKizunaMaxLevel_Private_Static_Boolean_IReadOnlyCollection_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00120344 File Offset: 0x0011E544
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 90674, RefRangeEnd = 90679, XrefRangeStart = 90666, XrefRangeEnd = 90674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTitle(string key, bool isNew = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNew;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr_GetTitle_Private_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x00120390 File Offset: 0x0011E590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_PartyStageToEnd_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00016D52 File Offset: 0x00014F52
		public DS_PartyStageToEnd_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x001203CC File Offset: 0x0011E5CC
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x00016D5B File Offset: 0x00014F5B
		public unsafe static Dictionary<SceneDirector.StaffScenePlayBackIndicator, string> dlcPartyStageKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlcPartyStageKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SceneDirector.StaffScenePlayBackIndicator, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlcPartyStageKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x001203F4 File Offset: 0x0011E5F4
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x00016D6D File Offset: 0x00014F6D
		public unsafe static Dictionary<SceneDirector.StaffScenePlayBackIndicator, string> dlcCGEventKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlcCGEventKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SceneDirector.StaffScenePlayBackIndicator, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlcCGEventKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x0012041C File Offset: 0x0011E61C
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x00016D7F File Offset: 0x00014F7F
		public unsafe static Il2CppStructArray<int> mainKizuna
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_mainKizuna, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_mainKizuna, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x00120444 File Offset: 0x0011E644
		// (set) Token: 0x060026CA RID: 9930 RVA: 0x00016D91 File Offset: 0x00014F91
		public unsafe static Il2CppStructArray<int> dlc1Kizuna
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc1Kizuna, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc1Kizuna, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x0012046C File Offset: 0x0011E66C
		// (set) Token: 0x060026CC RID: 9932 RVA: 0x00016DA3 File Offset: 0x00014FA3
		public unsafe static Il2CppStructArray<int> dlc2Kizuna
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc2Kizuna, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc2Kizuna, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x00120494 File Offset: 0x0011E694
		// (set) Token: 0x060026CE RID: 9934 RVA: 0x00016DB5 File Offset: 0x00014FB5
		public unsafe static Il2CppStructArray<int> dlc3Kizuna
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc3Kizuna, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc3Kizuna, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x001204BC File Offset: 0x0011E6BC
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x00016DC7 File Offset: 0x00014FC7
		public unsafe static Il2CppStructArray<int> dlc4Kizuna
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc4Kizuna, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc4Kizuna, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x001204E4 File Offset: 0x0011E6E4
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x00016DD9 File Offset: 0x00014FD9
		public unsafe static Il2CppStructArray<int> dlc5Kizuna
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc5Kizuna, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_dlc5Kizuna, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x0012050C File Offset: 0x0011E70C
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x00016DEB File Offset: 0x00014FEB
		public unsafe bool mainStory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_mainStory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_mainStory)) = value;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x00120534 File Offset: 0x0011E734
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x00016E06 File Offset: 0x00015006
		public unsafe DialogPackage readyDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_readyDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_readyDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x00120564 File Offset: 0x0011E764
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x00016E25 File Offset: 0x00015025
		public unsafe DialogPackage newMusicReadyDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_newMusicReadyDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_newMusicReadyDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x00120594 File Offset: 0x0011E794
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x00016E44 File Offset: 0x00015044
		public unsafe DialogPackage startDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_startDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_startDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x001205C4 File Offset: 0x0011E7C4
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x00016E63 File Offset: 0x00015063
		public unsafe DialogPackage extraStartDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_extraStartDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_extraStartDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x001205F4 File Offset: 0x0011E7F4
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x00016E82 File Offset: 0x00015082
		public unsafe int acceptAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_acceptAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_acceptAddFrames)) = value;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x0012061C File Offset: 0x0011E81C
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x00016E9D File Offset: 0x0001509D
		public unsafe int refuseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_refuseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.NativeFieldInfoPtr_refuseAddFrames)) = value;
			}
		}

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeFieldInfoPtr_dlcPartyStageKey;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeFieldInfoPtr_dlcCGEventKey;

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeFieldInfoPtr_mainKizuna;

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeFieldInfoPtr_dlc1Kizuna;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeFieldInfoPtr_dlc2Kizuna;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeFieldInfoPtr_dlc3Kizuna;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeFieldInfoPtr_dlc4Kizuna;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeFieldInfoPtr_dlc5Kizuna;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeFieldInfoPtr_mainStory;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeFieldInfoPtr_readyDialog;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeFieldInfoPtr_newMusicReadyDialog;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeFieldInfoPtr_startDialog;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeFieldInfoPtr_extraStartDialog;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeFieldInfoPtr_acceptAddFrames;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeFieldInfoPtr_refuseAddFrames;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnterAsync_Private_UniTaskVoid_0;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeMethodInfoPtr_ToEnd_Private_Void_StaffScenePlayBackIndicator_0;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeMethodInfoPtr_IsAllKizunaMaxLevel_Private_Static_Boolean_IReadOnlyCollection_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeMethodInfoPtr_GetTitle_Private_Static_String_String_Boolean_0;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000783 RID: 1923
		[ObfuscatedName("DayScene.TimelineExtensions.DS_PartyStageToEnd_Behaviour+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x0600A2D8 RID: 41688 RVA: 0x002ABFD8 File Offset: 0x002AA1D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr);
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeFieldInfoPtr_dlcIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr, "dlcIndicator");
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr, 100670219);
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr, 100670220);
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr, 100670221);
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr, 100670222);
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr, 100670223);
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr, 100670224);
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr, 100670225);
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr, 100670226);
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr, 100670227);
			}

			// Token: 0x0600A2D9 RID: 41689 RVA: 0x002AC0E0 File Offset: 0x002AA2E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2DA RID: 41690 RVA: 0x002AC11C File Offset: 0x002AA31C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90339, XrefRangeEnd = 90342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnterAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2DB RID: 41691 RVA: 0x002AC150 File Offset: 0x002AA350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90342, XrefRangeEnd = 90345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnterAsync_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2DC RID: 41692 RVA: 0x002AC184 File Offset: 0x002AA384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90345, XrefRangeEnd = 90348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnterAsync_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2DD RID: 41693 RVA: 0x002AC1B8 File Offset: 0x002AA3B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90348, XrefRangeEnd = 90351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnterAsync_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2DE RID: 41694 RVA: 0x002AC1EC File Offset: 0x002AA3EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90351, XrefRangeEnd = 90354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnterAsync_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2DF RID: 41695 RVA: 0x002AC220 File Offset: 0x002AA420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90354, XrefRangeEnd = 90357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnterAsync_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2E0 RID: 41696 RVA: 0x002AC254 File Offset: 0x002AA454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90357, XrefRangeEnd = 90360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnterAsync_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2E1 RID: 41697 RVA: 0x002AC288 File Offset: 0x002AA488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90360, XrefRangeEnd = 90366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnterAsync_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2E2 RID: 41698 RVA: 0x00057FA7 File Offset: 0x000561A7
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035BE RID: 13758
			// (get) Token: 0x0600A2E3 RID: 41699 RVA: 0x002AC2BC File Offset: 0x002AA4BC
			// (set) Token: 0x0600A2E4 RID: 41700 RVA: 0x00057FB0 File Offset: 0x000561B0
			public Nullable<SceneDirector.StaffScenePlayBackIndicator> dlcIndicator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeFieldInfoPtr_dlcIndicator);
					return new Nullable<SceneDirector.StaffScenePlayBackIndicator>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<SceneDirector.StaffScenePlayBackIndicator>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeFieldInfoPtr_dlcIndicator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<SceneDirector.StaffScenePlayBackIndicator>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170035BF RID: 13759
			// (get) Token: 0x0600A2E5 RID: 41701 RVA: 0x002AC2EC File Offset: 0x002AA4EC
			// (set) Token: 0x0600A2E6 RID: 41702 RVA: 0x00057FDE File Offset: 0x000561DE
			public unsafe DS_PartyStageToEnd_Behaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DS_PartyStageToEnd_Behaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006971 RID: 26993
			private static readonly IntPtr NativeFieldInfoPtr_dlcIndicator;

			// Token: 0x04006972 RID: 26994
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006973 RID: 26995
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006974 RID: 26996
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnterAsync_b__0_Internal_Void_0;

			// Token: 0x04006975 RID: 26997
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnterAsync_b__1_Internal_Void_0;

			// Token: 0x04006976 RID: 26998
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnterAsync_b__2_Internal_Void_0;

			// Token: 0x04006977 RID: 26999
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnterAsync_b__3_Internal_Void_0;

			// Token: 0x04006978 RID: 27000
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnterAsync_b__4_Internal_Void_0;

			// Token: 0x04006979 RID: 27001
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnterAsync_b__5_Internal_Void_0;

			// Token: 0x0400697A RID: 27002
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnterAsync_b__6_Internal_Void_0;

			// Token: 0x0400697B RID: 27003
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnterAsync_b__7_Internal_Void_0;
		}

		// Token: 0x02000784 RID: 1924
		[ObfuscatedName("DayScene.TimelineExtensions.DS_PartyStageToEnd_Behaviour+<OnBehaviourEnterAsync>d__16")]
		public sealed class _OnBehaviourEnterAsync_d__16 : ValueType
		{
			// Token: 0x0600A2E7 RID: 41703 RVA: 0x002AC31C File Offset: 0x002AA51C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnBehaviourEnterAsync_d__16()
			{
				Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "<OnBehaviourEnterAsync>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16>.NativeClassPtr);
				DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16>.NativeClassPtr, "<>1__state");
				DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16>.NativeClassPtr, "<>t__builder");
				DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16>.NativeClassPtr, "<>4__this");
				DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16>.NativeClassPtr, "<>8__1");
				DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr__eventOptionsData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16>.NativeClassPtr, "<eventOptionsData>5__2");
				DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16>.NativeClassPtr, "<>u__1");
				DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16>.NativeClassPtr, 100670228);
				DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16>.NativeClassPtr, 100670229);
			}

			// Token: 0x0600A2E8 RID: 41704 RVA: 0x002AC3E8 File Offset: 0x002AA5E8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90591, RefRangeEnd = 90593, XrefRangeStart = 90366, XrefRangeEnd = 90591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2E9 RID: 41705 RVA: 0x002AC420 File Offset: 0x002AA620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2EA RID: 41706 RVA: 0x00057FFD File Offset: 0x000561FD
			public _OnBehaviourEnterAsync_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A2EB RID: 41707 RVA: 0x00058006 File Offset: 0x00056206
			public _OnBehaviourEnterAsync_d__16() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x170035C0 RID: 13760
			// (get) Token: 0x0600A2EC RID: 41708 RVA: 0x002AC468 File Offset: 0x002AA668
			// (set) Token: 0x0600A2ED RID: 41709 RVA: 0x00058018 File Offset: 0x00056218
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170035C1 RID: 13761
			// (get) Token: 0x0600A2EE RID: 41710 RVA: 0x002AC490 File Offset: 0x002AA690
			// (set) Token: 0x0600A2EF RID: 41711 RVA: 0x00058033 File Offset: 0x00056233
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170035C2 RID: 13762
			// (get) Token: 0x0600A2F0 RID: 41712 RVA: 0x002AC4C0 File Offset: 0x002AA6C0
			// (set) Token: 0x0600A2F1 RID: 41713 RVA: 0x00058061 File Offset: 0x00056261
			public unsafe DS_PartyStageToEnd_Behaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DS_PartyStageToEnd_Behaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035C3 RID: 13763
			// (get) Token: 0x0600A2F2 RID: 41714 RVA: 0x002AC4F0 File Offset: 0x002AA6F0
			// (set) Token: 0x0600A2F3 RID: 41715 RVA: 0x00058080 File Offset: 0x00056280
			public unsafe DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DS_PartyStageToEnd_Behaviour.__c__DisplayClass16_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035C4 RID: 13764
			// (get) Token: 0x0600A2F4 RID: 41716 RVA: 0x002AC520 File Offset: 0x002AA720
			// (set) Token: 0x0600A2F5 RID: 41717 RVA: 0x0005809F File Offset: 0x0005629F
			public unsafe Dictionary<string, Action> _eventOptionsData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr__eventOptionsData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr__eventOptionsData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035C5 RID: 13765
			// (get) Token: 0x0600A2F6 RID: 41718 RVA: 0x002AC550 File Offset: 0x002AA750
			// (set) Token: 0x0600A2F7 RID: 41719 RVA: 0x000580BE File Offset: 0x000562BE
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour._OnBehaviourEnterAsync_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400697C RID: 27004
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400697D RID: 27005
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400697E RID: 27006
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400697F RID: 27007
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006980 RID: 27008
			private static readonly IntPtr NativeFieldInfoPtr__eventOptionsData_5__2;

			// Token: 0x04006981 RID: 27009
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006982 RID: 27010
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006983 RID: 27011
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000785 RID: 1925
		[ObfuscatedName("DayScene.TimelineExtensions.DS_PartyStageToEnd_Behaviour+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600A2F8 RID: 41720 RVA: 0x002AC580 File Offset: 0x002AA780
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0>.NativeClassPtr);
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_dlcIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0>.NativeClassPtr, "dlcIndicator");
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0>.NativeClassPtr, 100670230);
				DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ToEnd_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0>.NativeClassPtr, 100670231);
			}

			// Token: 0x0600A2F9 RID: 41721 RVA: 0x002AC5FC File Offset: 0x002AA7FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2FA RID: 41722 RVA: 0x002AC638 File Offset: 0x002AA838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90593, XrefRangeEnd = 90629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ToEnd_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0.NativeMethodInfoPtr__ToEnd_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2FB RID: 41723 RVA: 0x000580EC File Offset: 0x000562EC
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035C6 RID: 13766
			// (get) Token: 0x0600A2FC RID: 41724 RVA: 0x002AC66C File Offset: 0x002AA86C
			// (set) Token: 0x0600A2FD RID: 41725 RVA: 0x000580F5 File Offset: 0x000562F5
			public unsafe DS_PartyStageToEnd_Behaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DS_PartyStageToEnd_Behaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035C7 RID: 13767
			// (get) Token: 0x0600A2FE RID: 41726 RVA: 0x002AC69C File Offset: 0x002AA89C
			// (set) Token: 0x0600A2FF RID: 41727 RVA: 0x00058114 File Offset: 0x00056314
			public unsafe SceneDirector.StaffScenePlayBackIndicator dlcIndicator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_dlcIndicator);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd_Behaviour.__c__DisplayClass17_0.NativeFieldInfoPtr_dlcIndicator)) = value;
				}
			}

			// Token: 0x04006984 RID: 27012
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006985 RID: 27013
			private static readonly IntPtr NativeFieldInfoPtr_dlcIndicator;

			// Token: 0x04006986 RID: 27014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006987 RID: 27015
			private static readonly IntPtr NativeMethodInfoPtr__ToEnd_b__0_Internal_Void_0;
		}
	}
}
