using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000212 RID: 530
	public class NS_Set_CanOpenTrash : PlayableAsset
	{
		// Token: 0x06003DAD RID: 15789 RVA: 0x0016F840 File Offset: 0x0016DA40
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Set_CanOpenTrash()
		{
			Il2CppClassPointerStore<NS_Set_CanOpenTrash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Set_CanOpenTrash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Set_CanOpenTrash>.NativeClassPtr);
			NS_Set_CanOpenTrash.NativeFieldInfoPtr_canOpenTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Set_CanOpenTrash>.NativeClassPtr, "canOpenTrash");
			NS_Set_CanOpenTrash.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_CanOpenTrash>.NativeClassPtr, 100674590);
			NS_Set_CanOpenTrash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_CanOpenTrash>.NativeClassPtr, 100674591);
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x0016F8AC File Offset: 0x0016DAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137356, XrefRangeEnd = 137368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Set_CanOpenTrash.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x0016F914 File Offset: 0x0016DB14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Set_CanOpenTrash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Set_CanOpenTrash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Set_CanOpenTrash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x0002279D File Offset: 0x0002099D
		public NS_Set_CanOpenTrash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x0016F950 File Offset: 0x0016DB50
		// (set) Token: 0x06003DB2 RID: 15794 RVA: 0x000227A6 File Offset: 0x000209A6
		public unsafe bool canOpenTrash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_CanOpenTrash.NativeFieldInfoPtr_canOpenTrash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_CanOpenTrash.NativeFieldInfoPtr_canOpenTrash)) = value;
			}
		}

		// Token: 0x0400292B RID: 10539
		private static readonly IntPtr NativeFieldInfoPtr_canOpenTrash;

		// Token: 0x0400292C RID: 10540
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x0400292D RID: 10541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
