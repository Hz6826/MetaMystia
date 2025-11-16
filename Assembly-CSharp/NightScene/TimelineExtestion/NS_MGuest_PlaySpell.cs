using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000208 RID: 520
	public class NS_MGuest_PlaySpell : PlayableAsset
	{
		// Token: 0x06003D75 RID: 15733 RVA: 0x0016EC78 File Offset: 0x0016CE78
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_PlaySpell()
		{
			Il2CppClassPointerStore<NS_MGuest_PlaySpell>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_PlaySpell");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_PlaySpell>.NativeClassPtr);
			NS_MGuest_PlaySpell.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlaySpell>.NativeClassPtr, "label");
			NS_MGuest_PlaySpell.NativeFieldInfoPtr_isPositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlaySpell>.NativeClassPtr, "isPositive");
			NS_MGuest_PlaySpell.NativeFieldInfoPtr_visualOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlaySpell>.NativeClassPtr, "visualOnly");
			NS_MGuest_PlaySpell.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlaySpell>.NativeClassPtr, 100674570);
			NS_MGuest_PlaySpell.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlaySpell>.NativeClassPtr, 100674571);
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x0016ED0C File Offset: 0x0016CF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137241, XrefRangeEnd = 137258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_PlaySpell.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x0016ED74 File Offset: 0x0016CF74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_PlaySpell() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_PlaySpell>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_PlaySpell.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x0002265B File Offset: 0x0002085B
		public NS_MGuest_PlaySpell(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x0016EDB0 File Offset: 0x0016CFB0
		// (set) Token: 0x06003D7A RID: 15738 RVA: 0x00022664 File Offset: 0x00020864
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06003D7B RID: 15739 RVA: 0x0016EDD8 File Offset: 0x0016CFD8
		// (set) Token: 0x06003D7C RID: 15740 RVA: 0x00022683 File Offset: 0x00020883
		public unsafe bool isPositive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell.NativeFieldInfoPtr_isPositive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell.NativeFieldInfoPtr_isPositive)) = value;
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x06003D7D RID: 15741 RVA: 0x0016EE00 File Offset: 0x0016D000
		// (set) Token: 0x06003D7E RID: 15742 RVA: 0x0002269E File Offset: 0x0002089E
		public unsafe bool visualOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell.NativeFieldInfoPtr_visualOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlaySpell.NativeFieldInfoPtr_visualOnly)) = value;
			}
		}

		// Token: 0x0400290F RID: 10511
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04002910 RID: 10512
		private static readonly IntPtr NativeFieldInfoPtr_isPositive;

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeFieldInfoPtr_visualOnly;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
