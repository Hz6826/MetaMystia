using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001F5 RID: 501
	public class NS_Override_Cooker_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003CE5 RID: 15589 RVA: 0x0016D288 File Offset: 0x0016B488
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Override_Cooker_Behaviour()
		{
			Il2CppClassPointerStore<NS_Override_Cooker_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Override_Cooker_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Override_Cooker_Behaviour>.NativeClassPtr);
			NS_Override_Cooker_Behaviour.NativeFieldInfoPtr_cookerArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Override_Cooker_Behaviour>.NativeClassPtr, "cookerArray");
			NS_Override_Cooker_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Cooker_Behaviour>.NativeClassPtr, 100674532);
			NS_Override_Cooker_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Cooker_Behaviour>.NativeClassPtr, 100674533);
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x0016D2F4 File Offset: 0x0016B4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137012, XrefRangeEnd = 137017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Override_Cooker_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x0016D330 File Offset: 0x0016B530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Override_Cooker_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Override_Cooker_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Override_Cooker_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x000221EA File Offset: 0x000203EA
		public NS_Override_Cooker_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06003CE9 RID: 15593 RVA: 0x0016D36C File Offset: 0x0016B56C
		// (set) Token: 0x06003CEA RID: 15594 RVA: 0x000221F3 File Offset: 0x000203F3
		public unsafe Il2CppStructArray<int> cookerArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Cooker_Behaviour.NativeFieldInfoPtr_cookerArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Cooker_Behaviour.NativeFieldInfoPtr_cookerArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028C7 RID: 10439
		private static readonly IntPtr NativeFieldInfoPtr_cookerArray;

		// Token: 0x040028C8 RID: 10440
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028C9 RID: 10441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
