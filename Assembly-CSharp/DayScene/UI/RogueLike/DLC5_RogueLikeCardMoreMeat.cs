using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000E8 RID: 232
	public class DLC5_RogueLikeCardMoreMeat : DLC5_RogueLikeCardGiveItemAfterSettle
	{
		// Token: 0x06001AD4 RID: 6868 RVA: 0x000F7FE8 File Offset: 0x000F61E8
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardMoreMeat()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMeat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardMoreMeat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMeat>.NativeClassPtr);
			DLC5_RogueLikeCardMoreMeat.NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMeat>.NativeClassPtr, 100668123);
			DLC5_RogueLikeCardMoreMeat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMeat>.NativeClassPtr, 100668124);
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x000F8040 File Offset: 0x000F6240
		public unsafe override int TypeIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardMoreMeat.NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000F8088 File Offset: 0x000F6288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardMoreMeat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMeat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMeat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0001084B File Offset: 0x0000EA4B
		public DLC5_RogueLikeCardMoreMeat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
