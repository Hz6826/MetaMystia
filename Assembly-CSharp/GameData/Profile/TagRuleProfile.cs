using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002EF RID: 751
	public class TagRuleProfile : ScriptableObject
	{
		// Token: 0x06005A4F RID: 23119 RVA: 0x001CD088 File Offset: 0x001CB288
		// Note: this type is marked as 'beforefieldinit'.
		static TagRuleProfile()
		{
			Il2CppClassPointerStore<TagRuleProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "TagRuleProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TagRuleProfile>.NativeClassPtr);
			TagRuleProfile.NativeFieldInfoPtr_rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagRuleProfile>.NativeClassPtr, "rules");
			TagRuleProfile.NativeFieldInfoPtr_previews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagRuleProfile>.NativeClassPtr, "previews");
			TagRuleProfile.NativeFieldInfoPtr_tagType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagRuleProfile>.NativeClassPtr, "tagType");
			TagRuleProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TagRuleProfile>.NativeClassPtr, 100681429);
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x001CD108 File Offset: 0x001CB308
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TagRuleProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TagRuleProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TagRuleProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x00030CBD File Offset: 0x0002EEBD
		public TagRuleProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x06005A52 RID: 23122 RVA: 0x001CD144 File Offset: 0x001CB344
		// (set) Token: 0x06005A53 RID: 23123 RVA: 0x00030CC6 File Offset: 0x0002EEC6
		public unsafe Il2CppReferenceArray<TagRule> rules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TagRuleProfile.NativeFieldInfoPtr_rules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TagRule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TagRuleProfile.NativeFieldInfoPtr_rules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06005A54 RID: 23124 RVA: 0x001CD174 File Offset: 0x001CB374
		// (set) Token: 0x06005A55 RID: 23125 RVA: 0x00030CE5 File Offset: 0x0002EEE5
		public unsafe IndexProfile previews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TagRuleProfile.NativeFieldInfoPtr_previews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TagRuleProfile.NativeFieldInfoPtr_previews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06005A56 RID: 23126 RVA: 0x001CD1A4 File Offset: 0x001CB3A4
		// (set) Token: 0x06005A57 RID: 23127 RVA: 0x00030D04 File Offset: 0x0002EF04
		public unsafe TagRuleProfile.TagType tagType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TagRuleProfile.NativeFieldInfoPtr_tagType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TagRuleProfile.NativeFieldInfoPtr_tagType)) = value;
			}
		}

		// Token: 0x04003C21 RID: 15393
		private static readonly IntPtr NativeFieldInfoPtr_rules;

		// Token: 0x04003C22 RID: 15394
		private static readonly IntPtr NativeFieldInfoPtr_previews;

		// Token: 0x04003C23 RID: 15395
		private static readonly IntPtr NativeFieldInfoPtr_tagType;

		// Token: 0x04003C24 RID: 15396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CB8 RID: 3256
		public enum TagType
		{
			// Token: 0x040094BB RID: 38075
			FoodTagRule,
			// Token: 0x040094BC RID: 38076
			SGuestMappingRule
		}
	}
}
