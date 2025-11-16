using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003FD RID: 1021
	public class COM_LogicBranch_IsSwitchPlatform : PlayableAsset
	{
		// Token: 0x0600771A RID: 30490 RVA: 0x0022AF74 File Offset: 0x00229174
		// Note: this type is marked as 'beforefieldinit'.
		static COM_LogicBranch_IsSwitchPlatform()
		{
			Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_LogicBranch_IsSwitchPlatform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform>.NativeClassPtr);
			COM_LogicBranch_IsSwitchPlatform.NativeFieldInfoPtr_trueAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform>.NativeClassPtr, "trueAddFrames");
			COM_LogicBranch_IsSwitchPlatform.NativeFieldInfoPtr_falseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform>.NativeClassPtr, "falseAddFrames");
			COM_LogicBranch_IsSwitchPlatform.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform>.NativeClassPtr, 100687549);
			COM_LogicBranch_IsSwitchPlatform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform>.NativeClassPtr, 100687550);
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x0022AFF4 File Offset: 0x002291F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293041, XrefRangeEnd = 293055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_LogicBranch_IsSwitchPlatform.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x0022B05C File Offset: 0x0022925C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_LogicBranch_IsSwitchPlatform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_IsSwitchPlatform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x000406E1 File Offset: 0x0003E8E1
		public COM_LogicBranch_IsSwitchPlatform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002899 RID: 10393
		// (get) Token: 0x0600771E RID: 30494 RVA: 0x0022B098 File Offset: 0x00229298
		// (set) Token: 0x0600771F RID: 30495 RVA: 0x000406EA File Offset: 0x0003E8EA
		public unsafe int trueAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_IsSwitchPlatform.NativeFieldInfoPtr_trueAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_IsSwitchPlatform.NativeFieldInfoPtr_trueAddFrames)) = value;
			}
		}

		// Token: 0x1700289A RID: 10394
		// (get) Token: 0x06007720 RID: 30496 RVA: 0x0022B0C0 File Offset: 0x002292C0
		// (set) Token: 0x06007721 RID: 30497 RVA: 0x00040705 File Offset: 0x0003E905
		public unsafe int falseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_IsSwitchPlatform.NativeFieldInfoPtr_falseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_IsSwitchPlatform.NativeFieldInfoPtr_falseAddFrames)) = value;
			}
		}

		// Token: 0x04004EBC RID: 20156
		private static readonly IntPtr NativeFieldInfoPtr_trueAddFrames;

		// Token: 0x04004EBD RID: 20157
		private static readonly IntPtr NativeFieldInfoPtr_falseAddFrames;

		// Token: 0x04004EBE RID: 20158
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EBF RID: 20159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
