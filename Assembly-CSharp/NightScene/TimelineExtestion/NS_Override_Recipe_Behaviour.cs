using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001F6 RID: 502
	public class NS_Override_Recipe_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003CEB RID: 15595 RVA: 0x0016D39C File Offset: 0x0016B59C
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Override_Recipe_Behaviour()
		{
			Il2CppClassPointerStore<NS_Override_Recipe_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Override_Recipe_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Override_Recipe_Behaviour>.NativeClassPtr);
			NS_Override_Recipe_Behaviour.NativeFieldInfoPtr_recipeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Override_Recipe_Behaviour>.NativeClassPtr, "recipeArray");
			NS_Override_Recipe_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Recipe_Behaviour>.NativeClassPtr, 100674534);
			NS_Override_Recipe_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Recipe_Behaviour>.NativeClassPtr, 100674535);
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x0016D408 File Offset: 0x0016B608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137017, XrefRangeEnd = 137022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Override_Recipe_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x0016D444 File Offset: 0x0016B644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Override_Recipe_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Override_Recipe_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Override_Recipe_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x00022212 File Offset: 0x00020412
		public NS_Override_Recipe_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06003CEF RID: 15599 RVA: 0x0016D480 File Offset: 0x0016B680
		// (set) Token: 0x06003CF0 RID: 15600 RVA: 0x0002221B File Offset: 0x0002041B
		public unsafe Il2CppStructArray<int> recipeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Recipe_Behaviour.NativeFieldInfoPtr_recipeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Recipe_Behaviour.NativeFieldInfoPtr_recipeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028CA RID: 10442
		private static readonly IntPtr NativeFieldInfoPtr_recipeArray;

		// Token: 0x040028CB RID: 10443
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028CC RID: 10444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
