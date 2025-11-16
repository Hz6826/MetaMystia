using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x0200024C RID: 588
	[Serializable]
	public class WeightedConversationGroup : Object
	{
		// Token: 0x060049A2 RID: 18850 RVA: 0x0019E428 File Offset: 0x0019C628
		// Note: this type is marked as 'beforefieldinit'.
		static WeightedConversationGroup()
		{
			Il2CppClassPointerStore<WeightedConversationGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "WeightedConversationGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeightedConversationGroup>.NativeClassPtr);
			WeightedConversationGroup.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedConversationGroup>.NativeClassPtr, "id");
			WeightedConversationGroup.NativeFieldInfoPtr_weights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedConversationGroup>.NativeClassPtr, "weights");
			WeightedConversationGroup.NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedConversationGroup>.NativeClassPtr, 100677957);
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x0019E494 File Offset: 0x0019C694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76270, RefRangeEnd = 76271, XrefRangeStart = 76270, XrefRangeEnd = 76271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeightedConversationGroup(int id, Il2CppStructArray<int> weights) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeightedConversationGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(weights);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightedConversationGroup.NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x00025C66 File Offset: 0x00023E66
		public WeightedConversationGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x0019E4F0 File Offset: 0x0019C6F0
		// (set) Token: 0x060049A6 RID: 18854 RVA: 0x00025C6F File Offset: 0x00023E6F
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedConversationGroup.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedConversationGroup.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x060049A7 RID: 18855 RVA: 0x0019E518 File Offset: 0x0019C718
		// (set) Token: 0x060049A8 RID: 18856 RVA: 0x00025C8A File Offset: 0x00023E8A
		public unsafe Il2CppStructArray<int> weights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedConversationGroup.NativeFieldInfoPtr_weights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightedConversationGroup.NativeFieldInfoPtr_weights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400329C RID: 12956
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x0400329D RID: 12957
		private static readonly IntPtr NativeFieldInfoPtr_weights;

		// Token: 0x0400329E RID: 12958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x02000ACD RID: 2765
		public enum ConvType
		{
			// Token: 0x040084DD RID: 34013
			Norm,
			// Token: 0x040084DE RID: 34014
			Spec
		}
	}
}
