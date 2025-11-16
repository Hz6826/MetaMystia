using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000206 RID: 518
	public class NS_MGuest_PlayCustomDialog : PlayableAsset
	{
		// Token: 0x06003D5F RID: 15711 RVA: 0x0016E8DC File Offset: 0x0016CADC
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_PlayCustomDialog()
		{
			Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_PlayCustomDialog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog>.NativeClassPtr);
			NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog>.NativeClassPtr, "label");
			NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog>.NativeClassPtr, "title");
			NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_displayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog>.NativeClassPtr, "displayDuration");
			NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog>.NativeClassPtr, "shouldWaitForFinish");
			NS_MGuest_PlayCustomDialog.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog>.NativeClassPtr, 100674566);
			NS_MGuest_PlayCustomDialog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog>.NativeClassPtr, 100674567);
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x0016E984 File Offset: 0x0016CB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137204, XrefRangeEnd = 137224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_PlayCustomDialog.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x0016E9EC File Offset: 0x0016CBEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_PlayCustomDialog() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_PlayCustomDialog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_PlayCustomDialog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x00022580 File Offset: 0x00020780
		public NS_MGuest_PlayCustomDialog(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x0016EA28 File Offset: 0x0016CC28
		// (set) Token: 0x06003D64 RID: 15716 RVA: 0x00022589 File Offset: 0x00020789
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x0016EA50 File Offset: 0x0016CC50
		// (set) Token: 0x06003D66 RID: 15718 RVA: 0x000225A8 File Offset: 0x000207A8
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06003D67 RID: 15719 RVA: 0x0016EA78 File Offset: 0x0016CC78
		// (set) Token: 0x06003D68 RID: 15720 RVA: 0x000225C7 File Offset: 0x000207C7
		public unsafe float displayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_displayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_displayDuration)) = value;
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06003D69 RID: 15721 RVA: 0x0016EAA0 File Offset: 0x0016CCA0
		// (set) Token: 0x06003D6A RID: 15722 RVA: 0x000225E2 File Offset: 0x000207E2
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayCustomDialog.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x04002904 RID: 10500
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04002905 RID: 10501
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04002906 RID: 10502
		private static readonly IntPtr NativeFieldInfoPtr_displayDuration;

		// Token: 0x04002907 RID: 10503
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04002908 RID: 10504
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002909 RID: 10505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
