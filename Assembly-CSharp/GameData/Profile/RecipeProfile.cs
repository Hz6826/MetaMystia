using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002E8 RID: 744
	public class RecipeProfile : ScriptableObject
	{
		// Token: 0x06005A0F RID: 23055 RVA: 0x001CC658 File Offset: 0x001CA858
		// Note: this type is marked as 'beforefieldinit'.
		static RecipeProfile()
		{
			Il2CppClassPointerStore<RecipeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "RecipeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeProfile>.NativeClassPtr);
			RecipeProfile.NativeFieldInfoPtr_recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeProfile>.NativeClassPtr, "recipes");
			RecipeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeProfile>.NativeClassPtr, 100681403);
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x001CC6B0 File Offset: 0x001CA8B0
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecipeProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x00030A35 File Offset: 0x0002EC35
		public RecipeProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x06005A12 RID: 23058 RVA: 0x001CC6EC File Offset: 0x001CA8EC
		// (set) Token: 0x06005A13 RID: 23059 RVA: 0x00030A3E File Offset: 0x0002EC3E
		public unsafe Il2CppReferenceArray<Recipe> recipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeProfile.NativeFieldInfoPtr_recipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeProfile.NativeFieldInfoPtr_recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C02 RID: 15362
		private static readonly IntPtr NativeFieldInfoPtr_recipes;

		// Token: 0x04003C03 RID: 15363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
