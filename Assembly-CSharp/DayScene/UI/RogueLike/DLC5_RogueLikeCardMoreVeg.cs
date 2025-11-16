using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000EB RID: 235
	public class DLC5_RogueLikeCardMoreVeg : DLC5_RogueLikeCardGiveItemAfterSettle
	{
		// Token: 0x06001AE6 RID: 6886 RVA: 0x000F8438 File Offset: 0x000F6638
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardMoreVeg()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardMoreVeg>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardMoreVeg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreVeg>.NativeClassPtr);
			DLC5_RogueLikeCardMoreVeg.NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreVeg>.NativeClassPtr, 100668140);
			DLC5_RogueLikeCardMoreVeg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreVeg>.NativeClassPtr, 100668141);
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x000F8490 File Offset: 0x000F6690
		public unsafe override int TypeIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardMoreVeg.NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x000F84D8 File Offset: 0x000F66D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardMoreVeg() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreVeg>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreVeg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x000108A0 File Offset: 0x0000EAA0
		public DLC5_RogueLikeCardMoreVeg(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
