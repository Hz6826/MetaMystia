using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002D8 RID: 728
	public class IngredientProfile : ScriptableObject
	{
		// Token: 0x06005996 RID: 22934 RVA: 0x001CB310 File Offset: 0x001C9510
		// Note: this type is marked as 'beforefieldinit'.
		static IngredientProfile()
		{
			Il2CppClassPointerStore<IngredientProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "IngredientProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientProfile>.NativeClassPtr);
			IngredientProfile.NativeFieldInfoPtr_ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientProfile>.NativeClassPtr, "ingredients");
			IngredientProfile.NativeFieldInfoPtr_prefixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientProfile>.NativeClassPtr, "prefixes");
			IngredientProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientProfile>.NativeClassPtr, 100681351);
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x001CB37C File Offset: 0x001C957C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IngredientProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005998 RID: 22936 RVA: 0x0003059E File Offset: 0x0002E79E
		public IngredientProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x06005999 RID: 22937 RVA: 0x001CB3B8 File Offset: 0x001C95B8
		// (set) Token: 0x0600599A RID: 22938 RVA: 0x000305A7 File Offset: 0x0002E7A7
		public unsafe Il2CppReferenceArray<Ingredient> ingredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientProfile.NativeFieldInfoPtr_ingredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Ingredient>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientProfile.NativeFieldInfoPtr_ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x0600599B RID: 22939 RVA: 0x001CB3E8 File Offset: 0x001C95E8
		// (set) Token: 0x0600599C RID: 22940 RVA: 0x000305C6 File Offset: 0x0002E7C6
		public unsafe Il2CppStructArray<int> prefixes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientProfile.NativeFieldInfoPtr_prefixes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientProfile.NativeFieldInfoPtr_prefixes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BCA RID: 15306
		private static readonly IntPtr NativeFieldInfoPtr_ingredients;

		// Token: 0x04003BCB RID: 15307
		private static readonly IntPtr NativeFieldInfoPtr_prefixes;

		// Token: 0x04003BCC RID: 15308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
