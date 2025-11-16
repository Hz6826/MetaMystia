using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000209 RID: 521
	public class NS_MGuest_SetPatient : PlayableAsset
	{
		// Token: 0x06003D7F RID: 15743 RVA: 0x0016EE28 File Offset: 0x0016D028
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_SetPatient()
		{
			Il2CppClassPointerStore<NS_MGuest_SetPatient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_SetPatient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_SetPatient>.NativeClassPtr);
			NS_MGuest_SetPatient.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_SetPatient>.NativeClassPtr, "label");
			NS_MGuest_SetPatient.NativeFieldInfoPtr_targetPatient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_SetPatient>.NativeClassPtr, "targetPatient");
			NS_MGuest_SetPatient.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_SetPatient>.NativeClassPtr, 100674572);
			NS_MGuest_SetPatient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_SetPatient>.NativeClassPtr, 100674573);
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x0016EEA8 File Offset: 0x0016D0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137258, XrefRangeEnd = 137273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_SetPatient.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x0016EF10 File Offset: 0x0016D110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_SetPatient() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_SetPatient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_SetPatient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x000226B9 File Offset: 0x000208B9
		public NS_MGuest_SetPatient(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x0016EF4C File Offset: 0x0016D14C
		// (set) Token: 0x06003D84 RID: 15748 RVA: 0x000226C2 File Offset: 0x000208C2
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_SetPatient.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_SetPatient.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06003D85 RID: 15749 RVA: 0x0016EF74 File Offset: 0x0016D174
		// (set) Token: 0x06003D86 RID: 15750 RVA: 0x000226E1 File Offset: 0x000208E1
		public unsafe int targetPatient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_SetPatient.NativeFieldInfoPtr_targetPatient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_SetPatient.NativeFieldInfoPtr_targetPatient)) = value;
			}
		}

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeFieldInfoPtr_targetPatient;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
