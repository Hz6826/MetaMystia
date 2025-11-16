using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x020000C1 RID: 193
	public class DaySceneFastTravelPannel : MonoBehaviour
	{
		// Token: 0x0600158E RID: 5518 RVA: 0x000E6F64 File Offset: 0x000E5164
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneFastTravelPannel()
		{
			Il2CppClassPointerStore<DaySceneFastTravelPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneFastTravelPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneFastTravelPannel>.NativeClassPtr);
			DaySceneFastTravelPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneFastTravelPannel>.NativeClassPtr, 100667155);
			DaySceneFastTravelPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneFastTravelPannel>.NativeClassPtr, 100667156);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x000E6FBC File Offset: 0x000E51BC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneFastTravelPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x000E6FF8 File Offset: 0x000E51F8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneFastTravelPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneFastTravelPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneFastTravelPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0000D6CD File Offset: 0x0000B8CD
		public DaySceneFastTravelPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
