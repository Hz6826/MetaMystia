using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003FF RID: 1023
	public class COM_LogicBranch_UI_OpenSelectionPannel : PlayableAsset
	{
		// Token: 0x06007728 RID: 30504 RVA: 0x0022B220 File Offset: 0x00229420
		// Note: this type is marked as 'beforefieldinit'.
		static COM_LogicBranch_UI_OpenSelectionPannel()
		{
			Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_LogicBranch_UI_OpenSelectionPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel>.NativeClassPtr);
			COM_LogicBranch_UI_OpenSelectionPannel.NativeFieldInfoPtr_pannelGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel>.NativeClassPtr, "pannelGameObject");
			COM_LogicBranch_UI_OpenSelectionPannel.NativeFieldInfoPtr_acceptAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel>.NativeClassPtr, "acceptAddFrames");
			COM_LogicBranch_UI_OpenSelectionPannel.NativeFieldInfoPtr_refuseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel>.NativeClassPtr, "refuseAddFrames");
			COM_LogicBranch_UI_OpenSelectionPannel.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel>.NativeClassPtr, 100687553);
			COM_LogicBranch_UI_OpenSelectionPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel>.NativeClassPtr, 100687554);
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x0022B2B4 File Offset: 0x002294B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293067, XrefRangeEnd = 293084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_LogicBranch_UI_OpenSelectionPannel.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x0022B31C File Offset: 0x0022951C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_LogicBranch_UI_OpenSelectionPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x00040744 File Offset: 0x0003E944
		public COM_LogicBranch_UI_OpenSelectionPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x0600772C RID: 30508 RVA: 0x0022B358 File Offset: 0x00229558
		// (set) Token: 0x0600772D RID: 30509 RVA: 0x0004074D File Offset: 0x0003E94D
		public unsafe GameObject pannelGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel.NativeFieldInfoPtr_pannelGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel.NativeFieldInfoPtr_pannelGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x0600772E RID: 30510 RVA: 0x0022B388 File Offset: 0x00229588
		// (set) Token: 0x0600772F RID: 30511 RVA: 0x0004076C File Offset: 0x0003E96C
		public unsafe int acceptAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel.NativeFieldInfoPtr_acceptAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel.NativeFieldInfoPtr_acceptAddFrames)) = value;
			}
		}

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x06007730 RID: 30512 RVA: 0x0022B3B0 File Offset: 0x002295B0
		// (set) Token: 0x06007731 RID: 30513 RVA: 0x00040787 File Offset: 0x0003E987
		public unsafe int refuseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel.NativeFieldInfoPtr_refuseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel.NativeFieldInfoPtr_refuseAddFrames)) = value;
			}
		}

		// Token: 0x04004EC3 RID: 20163
		private static readonly IntPtr NativeFieldInfoPtr_pannelGameObject;

		// Token: 0x04004EC4 RID: 20164
		private static readonly IntPtr NativeFieldInfoPtr_acceptAddFrames;

		// Token: 0x04004EC5 RID: 20165
		private static readonly IntPtr NativeFieldInfoPtr_refuseAddFrames;

		// Token: 0x04004EC6 RID: 20166
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EC7 RID: 20167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
