using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200020D RID: 525
	public class NS_Override_Recipe : PlayableAsset
	{
		// Token: 0x06003D97 RID: 15767 RVA: 0x0016F310 File Offset: 0x0016D510
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Override_Recipe()
		{
			Il2CppClassPointerStore<NS_Override_Recipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Override_Recipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Override_Recipe>.NativeClassPtr);
			NS_Override_Recipe.NativeFieldInfoPtr_recipeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Override_Recipe>.NativeClassPtr, "recipeArray");
			NS_Override_Recipe.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Recipe>.NativeClassPtr, 100674580);
			NS_Override_Recipe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Recipe>.NativeClassPtr, 100674581);
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x0016F37C File Offset: 0x0016D57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137307, XrefRangeEnd = 137320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Override_Recipe.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x0016F3E4 File Offset: 0x0016D5E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Override_Recipe() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Override_Recipe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Override_Recipe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00022751 File Offset: 0x00020951
		public NS_Override_Recipe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06003D9B RID: 15771 RVA: 0x0016F420 File Offset: 0x0016D620
		// (set) Token: 0x06003D9C RID: 15772 RVA: 0x0002275A File Offset: 0x0002095A
		public unsafe Il2CppStructArray<int> recipeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Recipe.NativeFieldInfoPtr_recipeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Recipe.NativeFieldInfoPtr_recipeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002920 RID: 10528
		private static readonly IntPtr NativeFieldInfoPtr_recipeArray;

		// Token: 0x04002921 RID: 10529
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002922 RID: 10530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
