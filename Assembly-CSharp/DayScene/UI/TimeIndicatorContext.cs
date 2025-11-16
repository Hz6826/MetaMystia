using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DayScene.UI
{
	// Token: 0x020000CE RID: 206
	public sealed class TimeIndicatorContext : ValueType
	{
		// Token: 0x060018D4 RID: 6356 RVA: 0x000F0EDC File Offset: 0x000EF0DC
		// Note: this type is marked as 'beforefieldinit'.
		static TimeIndicatorContext()
		{
			Il2CppClassPointerStore<TimeIndicatorContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "TimeIndicatorContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeIndicatorContext>.NativeClassPtr);
			TimeIndicatorContext.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeIndicatorContext>.NativeClassPtr, "CurrentTime");
			TimeIndicatorContext.NativeFieldInfoPtr_TargetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeIndicatorContext>.NativeClassPtr, "TargetTime");
			TimeIndicatorContext.NativeFieldInfoPtr_CostTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeIndicatorContext>.NativeClassPtr, "CostTime");
			TimeIndicatorContext.NativeFieldInfoPtr_CostMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeIndicatorContext>.NativeClassPtr, "CostMoney");
			TimeIndicatorContext.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_TimeSpan_TimeSpan_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeIndicatorContext>.NativeClassPtr, 100667707);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x000F0F70 File Offset: 0x000EF170
		[CallerCount(0)]
		public unsafe TimeIndicatorContext(TimeSpan currentTime, TimeSpan targetTime, TimeSpan costTime, Nullable<int> costMoney) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeIndicatorContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref costTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(costMoney));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeIndicatorContext.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_TimeSpan_TimeSpan_Nullable_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0000F7AE File Offset: 0x0000D9AE
		public TimeIndicatorContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0000F7B7 File Offset: 0x0000D9B7
		public TimeIndicatorContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeIndicatorContext>.NativeClassPtr))
		{
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x000F0FF0 File Offset: 0x000EF1F0
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x0000F7C9 File Offset: 0x0000D9C9
		public unsafe TimeSpan CurrentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeIndicatorContext.NativeFieldInfoPtr_CurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeIndicatorContext.NativeFieldInfoPtr_CurrentTime)) = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x000F1018 File Offset: 0x000EF218
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x0000F7E4 File Offset: 0x0000D9E4
		public unsafe TimeSpan TargetTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeIndicatorContext.NativeFieldInfoPtr_TargetTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeIndicatorContext.NativeFieldInfoPtr_TargetTime)) = value;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x000F1040 File Offset: 0x000EF240
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x0000F7FF File Offset: 0x0000D9FF
		public unsafe TimeSpan CostTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeIndicatorContext.NativeFieldInfoPtr_CostTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeIndicatorContext.NativeFieldInfoPtr_CostTime)) = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x000F1068 File Offset: 0x000EF268
		// (set) Token: 0x060018DF RID: 6367 RVA: 0x0000F81A File Offset: 0x0000DA1A
		public Nullable<int> CostMoney
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeIndicatorContext.NativeFieldInfoPtr_CostMoney);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeIndicatorContext.NativeFieldInfoPtr_CostMoney), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTime;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeFieldInfoPtr_TargetTime;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeFieldInfoPtr_CostTime;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeFieldInfoPtr_CostMoney;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_TimeSpan_TimeSpan_Nullable_1_Int32_0;
	}
}
