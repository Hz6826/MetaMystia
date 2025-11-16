using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.RunTime.Common
{
	// Token: 0x02000227 RID: 551
	[StructLayout(2)]
	public struct GameDate
	{
		// Token: 0x0600418F RID: 16783 RVA: 0x0017EDC4 File Offset: 0x0017CFC4
		// Note: this type is marked as 'beforefieldinit'.
		static GameDate()
		{
			Il2CppClassPointerStore<GameDate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.Common", "GameDate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDate>.NativeClassPtr);
			GameDate.NativeFieldInfoPtr_daysOfTheWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDate>.NativeClassPtr, "daysOfTheWeek");
			GameDate.NativeFieldInfoPtr_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDate>.NativeClassPtr, "day");
			GameDate.NativeFieldInfoPtr_correctionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDate>.NativeClassPtr, "correctionOffset");
			GameDate.NativeMethodInfoPtr_ToCorrectedDay_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675680);
			GameDate.NativeMethodInfoPtr_get_Year_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675681);
			GameDate.NativeMethodInfoPtr_get_Week_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675682);
			GameDate.NativeMethodInfoPtr_get_DaysOfTheWeek_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675683);
			GameDate.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675684);
			GameDate.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675685);
			GameDate.NativeMethodInfoPtr_get_CurrentSeason_Public_get_Season_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675686);
			GameDate.NativeMethodInfoPtr_get_CorrectedDay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675687);
			GameDate.NativeMethodInfoPtr_set_CorrectedDay_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675688);
			GameDate.NativeMethodInfoPtr_get_ActuallDay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675689);
			GameDate.NativeMethodInfoPtr_set_ActuallDay_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675690);
			GameDate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675691);
			GameDate.NativeMethodInfoPtr_ToDetailedText_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675692);
			GameDate.NativeMethodInfoPtr_DetailedText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675693);
			GameDate.NativeMethodInfoPtr_op_Addition_Public_Static_GameDate_GameDate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDate>.NativeClassPtr, 100675694);
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x0017EF5C File Offset: 0x0017D15C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161682, RefRangeEnd = 161686, XrefRangeStart = 161682, XrefRangeEnd = 161682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ToCorrectedDay(int originDay)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref originDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_ToCorrectedDay_Public_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06004191 RID: 16785 RVA: 0x0017EF9C File Offset: 0x0017D19C
		public unsafe int Year
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_get_Year_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06004192 RID: 16786 RVA: 0x0017EFCC File Offset: 0x0017D1CC
		public unsafe int Week
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_get_Week_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06004193 RID: 16787 RVA: 0x0017EFFC File Offset: 0x0017D1FC
		public unsafe string DaysOfTheWeek
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 161693, RefRangeEnd = 161694, XrefRangeStart = 161686, XrefRangeEnd = 161693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_get_DaysOfTheWeek_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06004194 RID: 16788 RVA: 0x0017F028 File Offset: 0x0017D228
		public unsafe int Day
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06004195 RID: 16789 RVA: 0x0017F058 File Offset: 0x0017D258
		public unsafe int Month
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06004196 RID: 16790 RVA: 0x0017F088 File Offset: 0x0017D288
		public unsafe GameDate.Season CurrentSeason
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_get_CurrentSeason_Public_get_Season_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06004197 RID: 16791 RVA: 0x0017F0B8 File Offset: 0x0017D2B8
		// (set) Token: 0x06004198 RID: 16792 RVA: 0x0017F0E8 File Offset: 0x0017D2E8
		public unsafe int CorrectedDay
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 161694, RefRangeEnd = 161731, XrefRangeStart = 161694, XrefRangeEnd = 161694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_get_CorrectedDay_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 161731, RefRangeEnd = 161732, XrefRangeStart = 161731, XrefRangeEnd = 161731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_set_CorrectedDay_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06004199 RID: 16793 RVA: 0x0017F11C File Offset: 0x0017D31C
		// (set) Token: 0x0600419A RID: 16794 RVA: 0x0017F14C File Offset: 0x0017D34C
		public unsafe int ActuallDay
		{
			[CallerCount(140)]
			[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_get_ActuallDay_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25101, RefRangeEnd = 25115, XrefRangeStart = 25101, XrefRangeEnd = 25115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_set_ActuallDay_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x0017F180 File Offset: 0x0017D380
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 161743, RefRangeEnd = 161749, XrefRangeStart = 161732, XrefRangeEnd = 161743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x0017F1AC File Offset: 0x0017D3AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161766, RefRangeEnd = 161768, XrefRangeStart = 161749, XrefRangeEnd = 161766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToDetailedText(int inDay)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_ToDetailedText_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x0017F1E4 File Offset: 0x0017D3E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161781, RefRangeEnd = 161782, XrefRangeStart = 161768, XrefRangeEnd = 161781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DetailedText()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_DetailedText_Public_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x0017F210 File Offset: 0x0017D410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161782, RefRangeEnd = 161783, XrefRangeStart = 161782, XrefRangeEnd = 161782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameDate operator +(GameDate date, int day)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref date;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDate.NativeMethodInfoPtr_op_Addition_Public_Static_GameDate_GameDate_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x0002385B File Offset: 0x00021A5B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDate>.NativeClassPtr, ref this));
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x060041A0 RID: 16800 RVA: 0x0017F25C File Offset: 0x0017D45C
		// (set) Token: 0x060041A1 RID: 16801 RVA: 0x0002386D File Offset: 0x00021A6D
		public unsafe static Il2CppStringArray daysOfTheWeek
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GameDate.NativeFieldInfoPtr_daysOfTheWeek, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameDate.NativeFieldInfoPtr_daysOfTheWeek, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C2A RID: 11306
		private static readonly IntPtr NativeFieldInfoPtr_daysOfTheWeek;

		// Token: 0x04002C2B RID: 11307
		private static readonly IntPtr NativeFieldInfoPtr_day;

		// Token: 0x04002C2C RID: 11308
		private static readonly IntPtr NativeFieldInfoPtr_correctionOffset;

		// Token: 0x04002C2D RID: 11309
		private static readonly IntPtr NativeMethodInfoPtr_ToCorrectedDay_Public_Int32_Int32_0;

		// Token: 0x04002C2E RID: 11310
		private static readonly IntPtr NativeMethodInfoPtr_get_Year_Public_get_Int32_0;

		// Token: 0x04002C2F RID: 11311
		private static readonly IntPtr NativeMethodInfoPtr_get_Week_Public_get_Int32_0;

		// Token: 0x04002C30 RID: 11312
		private static readonly IntPtr NativeMethodInfoPtr_get_DaysOfTheWeek_Public_get_String_0;

		// Token: 0x04002C31 RID: 11313
		private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

		// Token: 0x04002C32 RID: 11314
		private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

		// Token: 0x04002C33 RID: 11315
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSeason_Public_get_Season_0;

		// Token: 0x04002C34 RID: 11316
		private static readonly IntPtr NativeMethodInfoPtr_get_CorrectedDay_Public_get_Int32_0;

		// Token: 0x04002C35 RID: 11317
		private static readonly IntPtr NativeMethodInfoPtr_set_CorrectedDay_Public_set_Void_Int32_0;

		// Token: 0x04002C36 RID: 11318
		private static readonly IntPtr NativeMethodInfoPtr_get_ActuallDay_Public_get_Int32_0;

		// Token: 0x04002C37 RID: 11319
		private static readonly IntPtr NativeMethodInfoPtr_set_ActuallDay_Public_set_Void_Int32_0;

		// Token: 0x04002C38 RID: 11320
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002C39 RID: 11321
		private static readonly IntPtr NativeMethodInfoPtr_ToDetailedText_Public_Static_String_Int32_0;

		// Token: 0x04002C3A RID: 11322
		private static readonly IntPtr NativeMethodInfoPtr_DetailedText_Public_String_0;

		// Token: 0x04002C3B RID: 11323
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_GameDate_GameDate_Int32_0;

		// Token: 0x04002C3C RID: 11324
		[FieldOffset(0)]
		public int day;

		// Token: 0x04002C3D RID: 11325
		[FieldOffset(4)]
		public int correctionOffset;

		// Token: 0x020009F9 RID: 2553
		public enum Season
		{
			// Token: 0x04007DA8 RID: 32168
			Spring,
			// Token: 0x04007DA9 RID: 32169
			Summer,
			// Token: 0x04007DAA RID: 32170
			Autumn,
			// Token: 0x04007DAB RID: 32171
			Winter
		}
	}
}
