using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200015A RID: 346
	public class DS_PartyStageToEnd : PlayableAsset
	{
		// Token: 0x06002771 RID: 10097 RVA: 0x00121D84 File Offset: 0x0011FF84
		// Note: this type is marked as 'beforefieldinit'.
		static DS_PartyStageToEnd()
		{
			Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_PartyStageToEnd");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr);
			DS_PartyStageToEnd.NativeFieldInfoPtr_mainStory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr, "mainStory");
			DS_PartyStageToEnd.NativeFieldInfoPtr_readyDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr, "readyDialog");
			DS_PartyStageToEnd.NativeFieldInfoPtr_newMusicReadyDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr, "newMusicReadyDialog");
			DS_PartyStageToEnd.NativeFieldInfoPtr_startDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr, "startDialog");
			DS_PartyStageToEnd.NativeFieldInfoPtr_extraStartDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr, "extraStartDialog");
			DS_PartyStageToEnd.NativeFieldInfoPtr_acceptAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr, "acceptAddFrames");
			DS_PartyStageToEnd.NativeFieldInfoPtr_refuseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr, "refuseAddFrames");
			DS_PartyStageToEnd.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr, 100670256);
			DS_PartyStageToEnd.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr, 100670257);
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00121E68 File Offset: 0x00120068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90889, XrefRangeEnd = 90917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_PartyStageToEnd.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00121ED0 File Offset: 0x001200D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_PartyStageToEnd() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_PartyStageToEnd>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_PartyStageToEnd.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x00017480 File Offset: 0x00015680
		public DS_PartyStageToEnd(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x00121F0C File Offset: 0x0012010C
		// (set) Token: 0x06002776 RID: 10102 RVA: 0x00017489 File Offset: 0x00015689
		public unsafe bool mainStory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_mainStory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_mainStory)) = value;
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x00121F34 File Offset: 0x00120134
		// (set) Token: 0x06002778 RID: 10104 RVA: 0x000174A4 File Offset: 0x000156A4
		public unsafe DialogPackage readyDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_readyDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_readyDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x00121F64 File Offset: 0x00120164
		// (set) Token: 0x0600277A RID: 10106 RVA: 0x000174C3 File Offset: 0x000156C3
		public unsafe DialogPackage newMusicReadyDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_newMusicReadyDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_newMusicReadyDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x00121F94 File Offset: 0x00120194
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x000174E2 File Offset: 0x000156E2
		public unsafe DialogPackage startDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_startDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_startDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x00121FC4 File Offset: 0x001201C4
		// (set) Token: 0x0600277E RID: 10110 RVA: 0x00017501 File Offset: 0x00015701
		public unsafe DialogPackage extraStartDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_extraStartDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_extraStartDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x0600277F RID: 10111 RVA: 0x00121FF4 File Offset: 0x001201F4
		// (set) Token: 0x06002780 RID: 10112 RVA: 0x00017520 File Offset: 0x00015720
		public unsafe int acceptAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_acceptAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_acceptAddFrames)) = value;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x0012201C File Offset: 0x0012021C
		// (set) Token: 0x06002782 RID: 10114 RVA: 0x0001753B File Offset: 0x0001573B
		public unsafe int refuseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_refuseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_PartyStageToEnd.NativeFieldInfoPtr_refuseAddFrames)) = value;
			}
		}

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeFieldInfoPtr_mainStory;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeFieldInfoPtr_readyDialog;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeFieldInfoPtr_newMusicReadyDialog;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeFieldInfoPtr_startDialog;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeFieldInfoPtr_extraStartDialog;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeFieldInfoPtr_acceptAddFrames;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeFieldInfoPtr_refuseAddFrames;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
